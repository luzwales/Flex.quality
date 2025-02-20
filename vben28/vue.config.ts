module.exports = {
  devServer: {
    proxy: {
      // 代理所有以 `/api` 开头的请求
      '/api': {
        target: 'http://localhost:44315', // 后端服务器的地址
        changeOrigin: true, // 允许跨域
        pathRewrite: {
          '^/api': '' // 如果后端接口没有 `/api` 前缀，可以去掉
        }
      }
    }
  }
};