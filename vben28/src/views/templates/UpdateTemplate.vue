<template>
  <BasicModal :canFullscreen="false" title="编辑模板组" @ok="submit" @register="registerModal">
    <BasicForm @register="registerTemplateForm"/>
  </BasicModal>
</template>

<script lang="ts">
import {defineComponent} from 'vue';
import {BasicModal, useModalInner} from '/@/components/Modal';
import {BasicForm, useForm} from '/@/components/Form/index';
import {editFormSchema, updateTemplateAsync} from '/@/views/templates/Template';

export default defineComponent({
  name: 'UpdateTemplate',
  components: {
    BasicModal,
    BasicForm,
  },
  emits: ['reload', 'register'],
  setup(_, {emit}) {
    const [registerTemplateForm, {getFieldsValue, setFieldsValue, validate}] = useForm({
      labelWidth: 120,
      schemas: editFormSchema,
      showActionButtonGroup: false,
    });
    const [registerModal, {changeOkLoading, closeModal}] = useModalInner((data) => {
      setFieldsValue({
        id: data.record.id,
        name: data.record.name,
        remark: data.record.remark,
      });
    });

    const submit = async () => {
      try {
        await validate();
        const params = getFieldsValue();
        changeOkLoading(true);
        await updateTemplateAsync({params});
        closeModal();
        emit('reload');
      } finally {
        changeOkLoading(false);
      }
    };

    return {
      registerModal,
      registerTemplateForm,
      submit,
    };
  },
});
</script>

<style lang="less" scoped></style>
