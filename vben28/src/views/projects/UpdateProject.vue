<template>
  <BasicModal :canFullscreen="false" title="编辑项目" @ok="submit" @register="registerModal">
    <BasicForm @register="registerProjectForm"/>
  </BasicModal>
</template>

<script lang="ts">
import {defineComponent} from 'vue';
import {BasicModal, useModalInner} from '/@/components/Modal';
import {BasicForm, useForm} from '/@/components/Form/index';
import {editFormSchema, updateProjectAsync} from './Project';

export default defineComponent({
  name: 'UpdateProject',
  components: {
    BasicModal,
    BasicForm,
  },
  emits: ['reload', 'register'],
  setup(_, {emit}) {
    const [registerProjectForm, {getFieldsValue, setFieldsValue, validate}] = useForm({
      labelWidth: 120,
      schemas: editFormSchema,
      showActionButtonGroup: false,
    });
    const [registerModal, {changeOkLoading, closeModal}] = useModalInner((data) => {
      setFieldsValue({
        id: data.record.id,
        name: data.record.name,
        companyName: data.record.companyName,
        projectName: data.record.projectName,
        owner: data.record.owner,
        remark: data.record.remark,
      });
    });

    const submit = async () => {
      try {
        await validate();
        const params = getFieldsValue();
        changeOkLoading(true);
        await updateProjectAsync({params});
        closeModal();
        emit('reload');
      } finally {
        changeOkLoading(false);
      }
    };

    return {
      registerModal,
      registerProjectForm,
      submit,
    };
  },
});
</script>

<style lang="less" scoped></style>
