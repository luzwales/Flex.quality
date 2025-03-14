<template>
  <BasicModal
    :canFullscreen="false"
    title="编辑实体"
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
  updateEntityModelFormSchema,
  updateEntityModelAsync,
} from '/@/views/entityModels/EntityModel';

export default defineComponent({
  name: 'UpdateEntityModel',
  components: {
    BasicModal,
    BasicForm,
  },
  emits: ['reload', 'register'],
  setup(_, {emit}) {
    const [
      registerUserForm,
      {getFieldsValue, setFieldsValue, updateSchema, validate, resetFields},
    ] = useForm({
      labelWidth: 120,
      schemas: updateEntityModelFormSchema,
      showActionButtonGroup: false,
    });

    const [registerModal, {changeOkLoading, closeModal}] = useModalInner((data) => {
      console.log(data);
      if (data.parentId) {
        updateSchema({
          field: 'relationalType',
          required: true,
          ifShow: true,
        });
      } else {
        updateSchema({
          field: 'relationalType',
          required: false,
          ifShow: false,
        });
      }

      setFieldsValue({
        id: data.id,
        code: data.code,
        description: data.description,
      });
      if (data.relationalType) {
        setFieldsValue({
          relationalType: String(data.relationalType),
        });
      }
    });

    const submit = async () => {
      try {
        await validate();
        const params = getFieldsValue();
        changeOkLoading(true);
        await updateEntityModelAsync({params});
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
