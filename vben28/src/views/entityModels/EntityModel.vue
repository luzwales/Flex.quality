<template>
  <div>
    <PageWrapper contentClass="flex" contentFullHeight dense>
      <div class="bg-white m-4 mr-0 w-1/4 xl:w-1/5 overflow-hidden">
        <BasicTree
          :beforeRightClick="getRightMenuList"
          :treeData="treeData"
          search
          showIcon
          toolbar
          @select="handleSelect"
        >
          <template #headerTitle>
            <a-button
              preIcon="ant-design:plus-circle-outlined"
              size="small"
              style="margin-left: 20px"
              type="primary"
              @click="openCreateAggregate"
            >
              新增聚合根
            </a-button>
          </template>
          <template #title="{ title, description }">
            <a-tooltip placement="right">
              <template #title>{{ description }}</template>
              {{ title }}
            </a-tooltip>
          </template>
        </BasicTree>
      </div>
      <div class="bg-white m-4 p-4 mr-0 w-3/4 xl:w-4/5">
        <a-tabs v-model:activeKey="activeKey">
          <a-tab-pane key="1" tab="属性">
            <BasicTable size="small" @register="registerTable">
              <template #toolbar>
                <a-button
                  preIcon="ant-design:plus-circle-outlined"
                  type="primary"
                  @click="openCreateEntityModelProperty"
                >
                  新增实体属性
                </a-button>
              </template>
              <template #bodyCell="{ column, record }">
                <template v-if="column.key === 'isRequired'">
                  {{ record.isRequired }}
                </template>
              </template>
              <template #action="{ record }">
                <TableAction
                  :actions="[
                    {
                      icon: 'clarity:note-edit-line',
                      label: '编辑',
                      onClick: handleEdit.bind(null, record),
                    },
                    {
                      icon: 'ant-design:delete-outlined',
                      color: 'error',
                      label: '删除',
                      popConfirm: {
                        title: '是否确认删除',
                        placement: 'left',
                        confirm: handleDelete.bind(null, record),
                      },
                    },
                  ]"
                />
              </template>
            </BasicTable>
          </a-tab-pane>
          <a-tab-pane key="2" tab="枚举">
            <PageWrapper contentClass="flex" contentFullHeight dense>
              <div class="bg-white m-4 mr-0 w-2/4 xl:w-2/4">
                <BasicTable
                  :clickToRowSelect="false"
                  size="small"
                  @register="registerEnumTable"
                  @selection-change="onSelectChange"
                >
                  <template #toolbar>
                    <a-button
                      preIcon="ant-design:plus-circle-outlined"
                      type="primary"
                      @click="openCreateEnumType"
                    >
                      新增枚举
                    </a-button>
                  </template>

                  <template #action="{ record }">
                    <TableAction
                      :actions="[
                        {
                          icon: 'clarity:note-edit-line',
                          label: '编辑',
                          onClick: handleEnumTypeEdit.bind(null, record),
                        },
                        {
                          icon: 'ant-design:delete-outlined',
                          color: 'error',
                          label: '删除',
                          popConfirm: {
                            title: '是否确认删除',
                            placement: 'left',
                            confirm: handleDeleteEnumType.bind(null, record),
                          },
                        },
                      ]"
                    />
                  </template>
                </BasicTable>
              </div>
              <div class="bg-white m-4 mr-0 w-2/4 xl:w-2/4">
                <BasicTable
                  :clickToRowSelect="false"
                  size="small"
                  @register="registerEnumPropertyTable"
                  @selection-change="onSelectChange"
                >
                  <template #toolbar>
                    <a-button
                      preIcon="ant-design:plus-circle-outlined"
                      type="primary"
                      @click="openCreateEnumTypeProperty"
                    >
                      新增枚举属性
                    </a-button>
                  </template>

                  <template #action="{ record }">
                    <TableAction
                      :actions="[
                        {
                          icon: 'clarity:note-edit-line',
                          label: '编辑',
                          onClick: handleEnumTypePropertyEdit.bind(null, record),
                        },
                        {
                          icon: 'ant-design:delete-outlined',
                          color: 'error',
                          label: '删除',
                          popConfirm: {
                            title: '是否确认删除',
                            placement: 'left',
                            confirm: handleDeleteEnumTypeProperty.bind(null, record),
                          },
                        },
                      ]"
                    />
                  </template>
                </BasicTable>
              </div>
            </PageWrapper>
          </a-tab-pane>
        </a-tabs>
      </div>
    </PageWrapper>
    <CreateAggregate
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerCreateAggregateModal"
      @reload="loadTree"
    />
    <CreateEntityModel
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerCreateEntityModelModal"
      @reload="loadTree"
    />
    <UpdateEntityModel
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerUpdateEntityModelModal"
      @reload="loadTree"
    />
    <CreateEntityModelProperty
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerCreateEntityModelPropertyModal"
      @reload="reload"
    />
    <UpdateEntityModelProperty
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerUpdateEntityModelPropertyModal"
      @reload="reload"
    />

    <CreateEnumType
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerCreateEnumTypeModal"
      @reload="reloadEnum"
    />

    <UpdateEnumType
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerUpdateEnumTypeModal"
      @reload="reloadEnum"
    />

    <CreateEnumTypeProperty
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerCreateEnumTypePropertyModal"
      @reload="reloadEnumProperty"
    />
    <UpdateEnumTypeProperty
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerUpdateEnumTypePropertyModal"
      @reload="reloadEnumProperty"
    />
  </div>
</template>
<script lang="ts">
import {defineComponent, ref, onActivated} from 'vue';
import {PageWrapper} from '/@/components/Page';
import {useRoute} from 'vue-router';
import {
  getTreeAsync,
  deleteAggregateAsync,
  deleteEntityModelAsync,
  searchFormSchema,
  tableColumns,
  getTableListAsync,
  deleteEntityModelPropertyAsync,
  getEnumTableListAsync,
  tableEnumColumns,
  deleteEnumTypeAsync,
  tableEnumProperyColumns,
  getEnumPropertyTableListAsync,
  deleteEnumTypePropertyAsync,
} from '/@/views/entityModels/EntityModel';
import {BasicTree, ContextMenuItem} from '/@/components/Tree';
import {BasicTable, TableAction, useTable} from '/@/components/Table';
import CreateAggregate from './CreateAggregate.vue';
import CreateEntityModel from './CreateEntityModel.vue';
import UpdateEntityModel from './UpdateEntityModel.vue';
import CreateEntityModelProperty from './CreateEntityModelProperty.vue';
import UpdateEntityModelProperty from './UpdateEntityModelProperty.vue';
import CreateEnumType from './CreateEnumType.vue';
import UpdateEnumType from './UpdateEnumType.vue';
import CreateEnumTypeProperty from './CreateEnumTypeProperty.vue';
import UpdateEnumTypeProperty from './UpdateEnumTypeProperty.vue';
import {useModal} from '/@/components/Modal';
import {useMessage} from '/@/hooks/web/useMessage';
import {Tabs, Tooltip} from 'ant-design-vue';
import {
  PageEntityModelInput,
  PageEnumTypeInput,
  PageEnumTypePropertyInput,
  GetEntityModelTreeOutput,
} from '/@/services/ServiceProxies';

export default defineComponent({
  name: 'EntityModel',
  components: {
    PageWrapper,
    BasicTree,
    BasicTable,
    TableAction,
    CreateAggregate,
    CreateEntityModel,
    UpdateEntityModel,
    Tabs,
    TabPane: Tabs.TabPane,
    Tooltip,
    CreateEntityModelProperty,
    UpdateEntityModelProperty,
    CreateEnumType,
    UpdateEnumType,
    CreateEnumTypeProperty,
    UpdateEnumTypeProperty,
  },
  setup() {
    const {createConfirm} = useMessage();
    let entityModelId;
    let enumTypeId;

    // 分页获取实体属性
    const getpropertyAsync = async (request: PageEntityModelInput) => {
      if (entityModelId) {
        request.filter = getForm().getFieldsValue().filter;
        request.id = entityModelId;
        return await getTableListAsync(request);
      }
    };
    // 分页获取实体下枚举
    const getEnumTypeAsync = async (request: PageEnumTypeInput) => {
      if (entityModelId) {
        request.filter = getEnumForm().getFieldsValue().filter;
        request.id = entityModelId;
        return await getEnumTableListAsync(request);
      }
    };

    // 分页获取枚举下属性
    const getEnumTypePropertyAsync = async (request: PageEnumTypePropertyInput) => {
      if (enumTypeId) {
        request.filter = getEnumProperyFrom().getFieldsValue().filter;
        request.id = enumTypeId;
        return await getEnumPropertyTableListAsync(request);
      }
    };
    // table配置
    const [registerTable, {reload, getForm}] = useTable({
      columns: tableColumns,
      formConfig: {
        labelWidth: 70,
        schemas: searchFormSchema,
        showResetButton: false,
      },
      api: getpropertyAsync,
      showTableSetting: true,
      useSearchForm: true,
      bordered: true,
      canResize: true,
      showIndexColumn: true,
      immediate: false,
      scroll: {x: true},
      actionColumn: {
        width: 220,
        title: '操作',
        dataIndex: 'action',
        slots: {customRender: 'action'},
      },
    });

    // 枚举table配置
    const [registerEnumTable, {reload: reloadEnum, getForm: getEnumForm}] = useTable({
      columns: tableEnumColumns,
      formConfig: {
        labelWidth: 70,
        schemas: searchFormSchema,
        showResetButton: false,
      },
      api: getEnumTypeAsync,
      showTableSetting: true,
      useSearchForm: true,
      bordered: true,
      canResize: false,
      showIndexColumn: true,
      immediate: true,
      rowSelection: {type: 'radio'},
      actionColumn: {
        width: 220,
        title: '操作',
        dataIndex: 'action',
        slots: {customRender: 'action'},
      },
    });

    const [
      registerEnumPropertyTable,
      {reload: reloadEnumProperty, getForm: getEnumProperyFrom},
    ] = useTable({
      columns: tableEnumProperyColumns,
      formConfig: {
        labelWidth: 70,
        schemas: searchFormSchema,
        showResetButton: false,
      },
      api: getEnumTypePropertyAsync,
      showTableSetting: true,
      useSearchForm: true,
      bordered: true,
      canResize: false,
      showIndexColumn: true,
      immediate: true,
      rowSelection: {type: 'radio'},
      actionColumn: {
        width: 220,
        title: '操作',
        dataIndex: 'action',
        slots: {customRender: 'action'},
      },
    });

    //勾选事件
    const onSelectChange = ({rows}) => {
      enumTypeId = rows[0].id;
      reloadEnumProperty();
    };

    const treeData = ref<GetEntityModelTreeOutput[]>([]);
    const route = useRoute();

    onActivated(async () => {
      if (route.query?.projectId) {
        await loadTree();
      } else {
        close();
      }
    });

    async function loadTree() {
      treeData.value = await getTreeAsync({projectId: route.query?.projectId});
    }

    // 树结构点击菜单
    function getRightMenuList(node: any): ContextMenuItem[] {
      return [
        {
          label: '新增',
          icon: 'ant-design:plus-circle-outlined',
          handler: () => {
            openCreateEntityModelModal(true, {
              entityModelId: node.key,
            });
          },
        },
        {
          label: '编辑',
          icon: 'clarity:note-edit-line',
          handler: () => {
            openUpdateEntityModelModal(true, {
              id: node.key,
              code: node.code,
              description: node.description,
              relationalType: node.relationalType,
              parentId: node.parentId,
            });
          },
        },
        {
          label: '删除',
          icon: 'ant-design:delete-outlined',
          handler: () => {
            createConfirm({
              iconType: 'warning',
              title: '提示',
              content: '确定要删除吗?',
              cancelText: '取消',
              onCancel: () => {
              },
              onOk: async () => {
                if (node.parentId) {
                  await deleteEntityModelAsync(node.parentId, node.key);
                } else {
                  await deleteAggregateAsync(node.key);
                }
                await loadTree();
              },
            });
          },
        },
      ];
    }

    const [registerCreateAggregateModal, {openModal: openCreateAggregateModal}] = useModal();

    function openCreateAggregate() {
      openCreateAggregateModal(true, {
        projectId: route.query?.projectId,
      });
    }

    const [registerCreateEnumTypeModal, {openModal: openCreateEnumTypeModal}] = useModal();

    function openCreateEnumType() {
      if (entityModelId) {
        openCreateEnumTypeModal(true, {
          entityModelId: entityModelId,
          projectId: route.query?.projectId,
        });
      } else {
        createConfirm({
          iconType: 'warning',
          title: '提示',
          content: '请选择实体',
        });
      }
    }

    const [registerCreateEntityModelModal, {openModal: openCreateEntityModelModal}] =
      useModal();
    const [registerUpdateEntityModelModal, {openModal: openUpdateEntityModelModal}] =
      useModal();

    const [registerCreateEnumTypePropertyModal, {openModal: openCreateEnumTypePropertyModal}] =
      useModal();

    function openCreateEnumTypeProperty() {
      if (enumTypeId) {
        openCreateEnumTypePropertyModal(true, {
          enumTypeId: enumTypeId,
        });
      } else {
        createConfirm({
          iconType: 'warning',
          title: '提示',
          content: '请选择枚举',
        });
      }
    }

    const [
      registerCreateEntityModelPropertyModal,
      {openModal: openCreateEntityModelPropertyModal},
    ] = useModal();

    function openCreateEntityModelProperty() {
      if (entityModelId) {
        openCreateEntityModelPropertyModal(true, {
          projectId: route.query?.projectId,
          entityModelId: entityModelId,
        });
      } else {
        createConfirm({
          iconType: 'warning',
          title: '提示',
          content: '请选择实体',
        });
      }
    }

    // 编辑枚举属性
    const [registerUpdateEnumTypePropertyModal, {openModal: openUpdateEnumTypePropertyModal}] =
      useModal();

    function handleEnumTypePropertyEdit(record: Recordable) {
      openUpdateEnumTypePropertyModal(true, {
        enumTypeId: enumTypeId,
        id: record.id,
        value: record.value,
        code: record.code,
        description: record.description,
      });
    }

    // 编辑枚举
    const [registerUpdateEnumTypeModal, {openModal: openUpdateEnumTypeModal}] = useModal();

    function handleEnumTypeEdit(record: Recordable) {
      openUpdateEnumTypeModal(true, {
        record: record,
      });
    }

    const [
      registerUpdateEntityModelPropertyModal,
      {openModal: openUpdateEntityModelPropertyModal},
    ] = useModal();

    function handleEdit(record: Recordable) {
      openUpdateEntityModelPropertyModal(true, {
        record: record,
      });
    }

    async function handleSelect(
      selectedKeys,
      e: { selected: boolean; selectedNodes; node; event },
    ) {
      activeKey.value = '1';
      getForm().setFieldsValue({
        id: e.node.key,
      });
      entityModelId = e.node.key;
      await reload({searchInfo: {id: e.node.key}});
    }

    const activeKey = ref('1');

    async function handleDelete(record: Recordable) {
      await deleteEntityModelPropertyAsync(record.entityModelId, record.id);
      await reload();
    }

    async function handleDeleteEnumType(record: Recordable) {
      await deleteEnumTypeAsync(record.id);
      await reloadEnum();
    }

    async function handleDeleteEnumTypeProperty(record: Recordable) {
      await deleteEnumTypePropertyAsync(record.id, enumTypeId);
      await reloadEnumProperty();
    }

    return {
      treeData,
      getRightMenuList,
      loadTree,
      registerCreateAggregateModal,
      openCreateAggregate,
      registerCreateEntityModelModal,
      registerUpdateEntityModelModal,
      registerTable,
      handleSelect,
      activeKey,

      registerCreateEntityModelPropertyModal,
      openCreateEntityModelProperty,
      reload,
      handleDelete,
      registerUpdateEntityModelPropertyModal,
      handleEdit,
      registerEnumTable,
      registerCreateEnumTypeModal,
      openCreateEnumType,
      handleDeleteEnumType,
      reloadEnum,
      handleEnumTypeEdit,
      registerUpdateEnumTypeModal,
      onSelectChange,
      registerEnumPropertyTable,
      registerCreateEnumTypePropertyModal,
      openCreateEnumTypeProperty,
      reloadEnumProperty,
      handleDeleteEnumTypeProperty,
      registerUpdateEnumTypePropertyModal,
      handleEnumTypePropertyEdit,
    };
  },
});
</script>

<style lang="less" scoped></style>
