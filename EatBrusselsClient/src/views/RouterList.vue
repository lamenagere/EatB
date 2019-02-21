<template>
    <div>
        <RestoList :resto="restoPerKitchenType" :title="`Le meilleur de la cuisine ${$route.params.kitchenType} à Bruxelles`"/>
    </div>
</template>

<script>
import RestoList from "@/components/RestoList.vue";
import axios from 'axios';
//import axios
export default {
  data(){
    return {
      restoPerKitchenType: [],
    }
  },
  components: {
    RestoList,
  },
  created(){
    axios
      .get("http://labo-team4-bf.azurewebsites.net/api/restaurants?kitchenType=" + this.$route.params.kitchenType)
        .then(response => {
           this.restoPerKitchenType = response.data  
        })
  }
  
}
</script>

<style>

</style>
