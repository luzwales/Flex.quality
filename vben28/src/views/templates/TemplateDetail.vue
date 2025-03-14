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
              size="small"
              style="margin-left: 20px"
              type="primary"
              @click="openCreateTemplateDetailModal"
            >
              创建
            </a-button>
          </template>
        </BasicTree>
      </div>
      <div class="bg-white m-4 p-4 mr-0 w-3/4 xl:w-4/5">
        <a-button
          v-show="showSaveTemplateBtn"
          preIcon="ant-design:sync-outlined"
          size="small"
          style="margin-left: 95%"
          type="primary"
          @click="saveTemplateContent"
        >
          保存
        </a-button>
        <CodeEditor v-model:value="content"/>
      </div>
    </PageWrapper>
    <CreateTemplateDetail
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerCreateTemplateModal"
      @reload="loadTree"
    />
    <UpdateTemplateDetail
      :bodyStyle="{ 'padding-top': '0' }"
      @register="registerUpdateTemplateModal"
      @reload="loadTree"
    />
  </div>
</template>
<script lang="ts">
import {defineComponent, ref, onActivated} from 'vue';
import {useRoute} from 'vue-router';
import {PageWrapper} from '/@/components/Page';
import {GetTemplateTreeOutput} from '/@/services/ServiceProxies';
import {
  getTemplateTreeAsync,
  deleteTemplateDetailAsync,
  saveTemplateDetailAsync,
} from '/@/views/templates/Template';
import {BasicTree, ContextMenuItem} from '/@/components/Tree';
import {CodeEditor} from '/@/components/CodeEditor';
import {useTabs} from '/@/hooks/web/useTabs';
import CreateTemplateDetail from './CreateTemplateDetail.vue';
import UpdateTemplateDetail from './UpdateTemplateDetail.vue';
import {useModal} from '/@/components/Modal';
import {useMessage} from '/@/hooks/web/useMessage';

export default defineComponent({
  name: 'TemplateDetail',
  components: {
    PageWrapper,
    BasicTree,
    CodeEditor,
    CreateTemplateDetail,
    UpdateTemplateDetail,
  },
  setup() {
    const treeData = ref<GetTemplateTreeOutput[]>([]);
    const showLine = ref<boolean>(true);
    const showIcon = ref<boolean>(true);
    const content = ref<string>('');
    const showSaveTemplateBtn = ref<boolean>(false);
    const {close} = useTabs();
    const [registerCreateTemplateModal, {openModal: openTemplateDetailModal}] = useModal();
    const [registerUpdateTemplateModal, {openModal: openUpdateTemplateDetailModal}] =
      useModal();
    const modeValue = ref('application/json');
    const route = useRoute();
    onActivated(async () => {
      if (route.query?.templateId) {
        await loadTree();
      } else {
        close();
      }
    });
    const {createConfirm} = useMessage();

    async function loadTree() {
      treeData.value = await getTemplateTreeAsync({templateId: route.query?.templateId});
    }

    function openCreateTemplateDetailModal() {
      openTemplateDetailModal(true, {
        templateId: route.query?.templateId,
      });
    }

    function getRightMenuList(node: any): ContextMenuItem[] {
      console.log(node);
      return [
        {
          label: '新增文件夹',
          icon: 'ant-design:folder-open-outlined',
          handler: () => {
            if (node.templateType == 20) {
              createConfirm({
                iconType: 'warning',
                title: '提示',
                content: '文件下不能添加文件夹',
              });
            } else {
              openTemplateDetailModal(true, {
                templateId: route.query?.templateId,
                parentId: node.key,
                templateType: 10,
              });
            }
          },
        },
        {
          label: '新增文件',
          icon: 'ant-design:file-twotone',
          handler: () => {
            openTemplateDetailModal(true, {
              templateId: route.query?.templateId,
              parentId: node.key,
              templateType: 20,
            });
          },
        },
        {
          label: '编辑',
          icon: 'clarity:note-edit-line',
          handler: () => {
            openUpdateTemplateDetailModal(true, {
              templateId: route.query?.templateId,
              templateDetailId: node.key,
              name: node.name,
              description: node.description,
              controlType: node.controlType,
              templateType: node.templateType,
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
              onCancel: () => {
              },
              onOk: async () => {
                await deleteTemplateDetailAsync({
                  templateId: route.query?.templateId,
                  templateDetailId: node.key,
                });
                await loadTree();
              },
            });
          },
        },
      ];
    }

    let currentTemplateDetailId;

    function handleSelect(selectedKeys, e: { selected: boolean; selectedNodes; node; event }) {
      currentTemplateDetailId = undefined;
      content.value = '';
      if (e.node.templateType != 10) {
        content.value = e.node.content;
        currentTemplateDetailId = e.node.key;
        showSaveTemplateBtn.value = true;
      } else {
        showSaveTemplateBtn.value = false;
      }
    }

    async function saveTemplateContent() {
      let templateId = route.query?.templateId;
      await saveTemplateDetailAsync(templateId, currentTemplateDetailId, content.value);
      await loadTree();
    }

    return {
      treeData,
      getRightMenuList,
      modeValue,
      showLine,
      showIcon,
      handleSelect,
      content,
      registerCreateTemplateModal,
      openCreateTemplateDetailModal,
      loadTree,
      registerUpdateTemplateModal,
      saveTemplateContent,
      showSaveTemplateBtn,
    };
  },
});
</script>

<style lang="less" scoped></style>
