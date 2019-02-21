<template>
  <div class="home">
    <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
    <Search/>
    <TypeFood/>
    <RestoList :resto="restoOnHome" title="Les restaurants les mieux notés"/>
  </div>
</template>

<script scoped>
// @ is an alias to /src
import TypeFood from '@/components/TypeFood.vue'
import RestoList from '@/components/RestoList.vue'
import Search from "@/components/Search.vue";
import axios from "axios";

export default {
  name: 'home',
  data(){
    return {
      restoOnHome: []
    }
  },
  components: {
    TypeFood,
    RestoList,
    Search
  },
  created() {
    axios.get("http://labo-team4-bf.azurewebsites.net/api/restaurants").then(response => {
      //console.log(JSON.stringify(response.data))
      this.restoOnHome = response.data;
    });
    // axios.get("http://localhost:63980/api/kitchentypes").then(response => {
    //   //console.log(JSON.stringify(response.data))
    //   this.restotypes = response.data;
    // });
  }
}
</script>
