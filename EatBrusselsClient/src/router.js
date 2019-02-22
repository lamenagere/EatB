import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import About from './views/About.vue'
import Restos from './views/Restos.vue'
import RouterList from './views/RouterList.vue'
import RouterZip from './views/RouterZip.vue'
import AddResto from './views/AddResto.vue'
import Admin from './views/Admin.vue'
import ModifyResto from './views/ModifyResto.vue'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: About
    },
    {
      path: '/restos/:id',
      name: 'restos',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: Restos
    },
    {
      path: '/routerlist/:kitchenType',
      name: 'routerlist',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: RouterList
    },
    {
      path: '/routerzip/:zip',
      name: 'routerzip',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: RouterZip
    },{
      path: '/addresto',
      name: 'addresto',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: AddResto
    },
    {
      path: '/admin',
      name: 'admin',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: Admin
    },{
      path: '/:id/modifyresto',
      name: 'modifyresto',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: ModifyResto
    }
    
  ]
})
