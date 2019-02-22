<template>
    <div>
        <RestoListAdmin :resto="restoAdmin" title="Tous les restaurants"/>
    </div>
</template>

<script scoped>
// @ is an alias to /src
import RestoListAdmin from '@/components/RestoListAdmin.vue'
import axios from "axios";

export default {
  name: 'home',
  data(){
    return {
      restoAdmin: []
    }
  },
  components: {
    RestoListAdmin
  },
  created() {
    axios.get("http://labo-team4-bf.azurewebsites.net/api/restaurants").then(response => {
      this.restoAdmin = response.data;
    });
  }
}
</script>

<style>

</style>

