const path = require('path');

module.exports = {
    lintOnSave: false,
    runtimeCompiler: true,
    configureWebpack: {
        devtool: 'source-map',
        resolve: {
          symlinks: false,
          alias: {
            vue: path.resolve(`./node_modules/vue`),
          },
        },
      },
    devServer: {
      proxy: {
        '/note': {
          target: 'http://localhost:5081/',
          changeOrigin: true,
          timeout: 120000,
        },
      },
    },
  };
  