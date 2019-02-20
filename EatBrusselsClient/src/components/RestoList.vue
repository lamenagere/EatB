<template>
  <div class="resto-pref">
    <h1 class="container">Les restaurants les mieux notés</h1>
    <div class="resto-list container">
      <Resto v-for="(r, index) in resto" :key="index" :resto="r"/>
    </div>
    <div class="more">
      <button>voir plus</button>
    </div>
  </div>
</template>

<script>
import Resto from "./Resto.vue";
import axios from "axios";

export default {
  data() {
    return {
      resto: [],
      // restotypes: [],
    };
  },
  components: {
    Resto
  },
  created() {
    axios.get("http://localhost:63980/api/restaurants").then(response => {
      //console.log(JSON.stringify(response.data))
      this.resto = response.data;
    });
    // axios.get("http://localhost:63980/api/kitchentypes").then(response => {
    //   //console.log(JSON.stringify(response.data))
    //   this.restotypes = response.data;
    // });
  }
};
</script>



<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
.resto-pref {
  background: rgb(243, 243, 243);
  padding-bottom: 100px;
}
h1 {
  font-family: "Roboto", sans-serif;
  text-align: left;
  margin-bottom: 40px;
  padding-top: 70px;
}
.resto-list {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
}
button {
  background: crimson;
  padding: 10px 15px;
  margin-top: 50px;
  color: white;
  border: none;
  cursor: pointer;
  font-weight: bold;
}
@media screen and (max-width: 1150px) {
  .resto-pref {
    padding-bottom: 70px;
  }
  h1 {
    margin: 0;
    padding-top: 70px;
    padding-bottom: 50px;
  }
}
@media screen and (max-width: 770px) {
  h1 {
    font-size: 1.6em;
  }
}
</style>




