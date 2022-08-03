import Vue from 'vue'
import App from './App.vue'
import BootstrapVue from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import '@/assets/styles.css'

Vue.config.productionTip = false
Vue.use(BootstrapVue)

new Vue({
  render: function (h) { return h(App) },
}).$mount('#app')
