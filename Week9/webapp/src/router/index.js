import Vue from 'vue';
import Router from 'vue-router';
import Home from '@/components/Home';
import Students from '@/components/Students';
import Instructors from '@/components/Instructors';
import { authGuard } from "../auth/authGuard"

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      component: Home
    },
    {
      path: '/home',
      component: Home
    },
    {
      path: '/students',
      name: "Students",
      component: Students,
      beforeEnter: authGuard
    },
    {
      path: '/instructors',
      name: "Instructors",
      component: Instructors,
      beforeEnter: authGuard
    }
  ]
})