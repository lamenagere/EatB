<template>
  <div class="home">
    <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
    <Search/>
    <TypeFood/>
    <RestoList/>
  </div>
</template>

<script scoped>
// @ is an alias to /src
import TypeFood from '@/components/TypeFood.vue'
import RestoList from '@/components/RestoList.vue'
import Search from "@/components/Search.vue";

export default {
  name: 'home',
  components: {
    TypeFood,
    RestoList,
    Search
  }
}
</script>
