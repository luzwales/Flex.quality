<template>
  <div>
    <BasicTable size="small" @register="registerTable">
      <template #toolbar>
        <a-button
          preIcon="ant-design:plus-circle-outlined"
          type="primary"
          @click="openCreateTemplateModal"
        >
          新增模板组
        </a-button>
      </template>
      <!-- <template #bodyCell="{ column, record }">
        <template v-if="column.key === 'name'">
          <router-link
            :to="{ name: 'TemplateDetail', query: { id: record.id } }"
            style="color: dodgerblue"
          >
            {{ record.name }}
          </router-link>
        </template>
      </template> -->
      <template #action="{ record }">
        <TableAction
          :actions="[
            {
              icon: 'ant-design:eye-outlined',
              label: '明细',
              onClick: handleLook.bind(null, record),
            },
            {
              icon: 'ant-design:book-outlined',
              label: '复制',
              onClick: handleCopy.bind(null, record),
            },
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

    <CreateTemplate
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerCreateTemplateModal"
      @reload="reload"
    />
    <UpdateTemplate
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerUpdateTemplateModal"
      @reload="reload"
    />
    <CopyTemplate
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerCopyTemplateModal"
      @reload="reload"
    />
  </div>
</template>

<script lang="ts">
import {defineComponent} from 'vue';
import {BasicTable, TableAction, useTable} from '/@/components/Table';
import {useRouter} from 'vue-router';
import {
  tableColumns,
  searchFormSchema,
  getTableListAsync,
  deleteTemplateAsync,
} from '/@/views/templates/Template';
import {useModal} from '/@/components/Modal';
import CreateTemplate from './CreateTemplate.vue';
import UpdateTemplate from './UpdateTemplate.vue';
import CopyTemplate from './CopyTemplate.vue';

export default defineComponent({
  name: 'Template',
  components: {
    BasicTable,
    TableAction,
    CreateTemplate,
    UpdateTemplate,
    CopyTemplate,
  },
  setup() {
    const router = useRouter();
    // table配置
    const [registerTable, {reload}] = useTable({
      columns: tableColumns,
      formConfig: {
        labelWidth: 70,
        schemas: searchFormSchema,
      },
      api: getTableListAsync,
      showTableSetting: true,
      useSearchForm: true,
      bordered: true,
      canResize: true,
      showIndexColumn: true,
      immediate: true,
      scroll: {x: true},
      actionColumn: {
        width: 220,
        title: '操作',
        dataIndex: 'action',
        slots: {customRender: 'action'},
      },
    });
    const [registerCreateTemplateModal, {openModal: openCreateTemplateModal}] = useModal();
    const [registerUpdateTemplateModal, {openModal: openUpdateTemplateModal}] = useModal();
    const [registerCopyTemplateModal, {openModal: openCopyTemplateModal}] = useModal();

    // const [registerTemplateDrawer, { openDrawer: openTemplateDetailDrawer }] = useDrawer();
    function handleEdit(record: Recordable) {
      openUpdateTemplateModal(true, {
        record: record,
      });
    }

    function handleCopy(record: Recordable) {
      openCopyTemplateModal(true, {
        record: record,
      });
    }

    async function handleDelete(record: Recordable) {
      await deleteTemplateAsync({id: record.id});
      await reload();
    }

    function handleLook(record: Recordable) {
      router.push({name: 'TemplateDetail', query: {templateId: record.id}});
    }

    return {
      registerTable,
      reload,
      registerCreateTemplateModal,
      openCreateTemplateModal,
      handleEdit,
      handleDelete,
      handleLook,
      registerUpdateTemplateModal,
      registerCopyTemplateModal,
      handleCopy,
    };
  },
});
</script>
