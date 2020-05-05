import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'
import Home from '../views/Home.vue'
import Cars from '../views/Cars.vue'
import AddCar from '../views/AddCar.vue'

Vue.use(VueRouter)

  const routes: Array<RouteConfig> = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/cars',
      name: 'Cars',
    component:Cars
    //component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  {
      path: '/add',
      name: 'AddCar',
      component:AddCar
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
