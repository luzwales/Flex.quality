<template>
  <BasicModal
    :canFullscreen="false"
    title="编辑模板"
    @cancel="cancel"
    @ok="submit"
    @register="registerModal"
  >
    <BasicForm @register="registerUserForm"/>
  </BasicModal>
</template>

<script lang="ts">
import {defineComponent} from 'vue';
import {BasicModal, useModalInner} from '/@/components/Modal';
import {BasicForm, useForm} from '/@/components/Form/index';
import {
  updateTemplateDetailSchema,
  updateTemplateDetailNoContentAsync,
} from '/@/views/templates/Template';

export default defineComponent({
  name: 'UpdateTemplateDetail',
  components: {
    BasicModal,
    BasicForm,
  },
  emits: ['reload', 'register'],
  setup(_, {emit}) {
    const [
      registerUserForm,
      {getFieldsValue, setFieldsValue, validate, resetFields, updateSchema, resetSchema},
    ] = useForm({
      labelWidth: 120,
      schemas: updateTemplateDetailSchema,
      showActionButtonGroup: false,
    });

    const [registerModal, {changeOkLoading, closeModal}] = useModalInner((data) => {
      console.log(data);
      if (data.templateType == 20) {
        setFieldsValue({
          controlType: data.controlType,
        });
        updateSchema({
          field: 'controlType',
          ifShow: true,
        });
      }
      setFieldsValue({
        templateId: data.templateId,
        templateDetailId: data.templateDetailId,
        name: data.name,
        description: data.description,
      });
    });

    const submit = async () => {
      try {
        await validate();
        const params = getFieldsValue();
        changeOkLoading(true);
        await updateTemplateDetailNoContentAsync({params});
        await resetFields();
        closeModal();
        emit('reload');
      } finally {
        changeOkLoading(false);
        resetSchema(updateTemplateDetailSchema);
      }
    };

    const cancel = () => {
      resetFields();
      closeModal();
    };
    return {
      registerModal,
      registerUserForm,
      submit,
      cancel,
    };
  },
});
</script>

<style lang="less" scoped></style>
