<template>
  <h2
    class="mb-3 text-3xl mb-[10px] xl:mb-[50px] dark:text-gray-200 text-blue-700 text-center enter-x xl:text-left"
  >
    {{ getFormTitle }}
  </h2>
</template>
<script lang="ts" setup>
import { computed, unref } from 'vue';
import { useI18n } from '/@/hooks/web/useI18n';
import { LoginStateEnum, useLoginState } from './useLogin';

const { t } = useI18n();

const { getLoginState } = useLoginState();

const getFormTitle = computed(() => {
  const titleObj = {
    [LoginStateEnum.RESET_PASSWORD]: t('sys.login.forgetFormTitle'),
    [LoginStateEnum.LOGIN]: t('sys.login.signInFormTitle'),
    [LoginStateEnum.REGISTER]: t('sys.login.signUpFormTitle'),
    [LoginStateEnum.MOBILE]: t('sys.login.mobileSignInFormTitle'),
    [LoginStateEnum.QR_CODE]: t('sys.login.qrSignInFormTitle'),
    [LoginStateEnum.TENANT]: t('sys.login.tenantFormTitle'),
  };
  return titleObj[unref(getLoginState)];
});
</script>
