<template>
  <BasicModal
    :canFullscreen="false"
    title="新增实体"
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
  createEntityModelFormSchema,
  createEntityModelAsync,
} from '/@/views/entityModels/EntityModel';

export default defineComponent({
  name: 'CreateEntityModel',
  components: {
    BasicModal,
    BasicForm,
  },
  emits: ['reload', 'register'],
  setup(_, {emit}) {
    const [registerUserForm, {getFieldsValue, setFieldsValue, resetFields, validate}] = useForm(
      {
        labelWidth: 120,
        schemas: createEntityModelFormSchema,
        showActionButtonGroup: false,
      },
    );

    const [registerModal, {changeOkLoading, closeModal}] = useModalInner((data) => {
      setFieldsValue({
        id: data.entityModelId,
      });
    });

    const submit = async () => {
      try {
        await validate();
        const params = getFieldsValue();
        changeOkLoading(true);
        await createEntityModelAsync({params});
        await resetFields();
        closeModal();
        emit('reload');
      } finally {
        changeOkLoading(false);
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
