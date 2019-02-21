<template>
    <div>
        <RestoList :resto="restoPerZipcode" :title="`Les meilleurs restaurants à ${$route.params.zip}`"/>
    </div>
</template>

<script>
import RestoList from "@/components/RestoList.vue";
import axios from 'axios';
//import axios
export default {
  data(){
    return {
      restoPerZipcode: []
    }
  },
  components: {
    RestoList,
  },
  created(){
        axios
      .get("http://labo-team4-bf.azurewebsites.net/api/restaurants?zipCode=" + this.$route.params.zip)
        .then(response => {
           this.restoPerZipcode = response.data  
        })
  }
  
}
</script>

<style>

</style>
