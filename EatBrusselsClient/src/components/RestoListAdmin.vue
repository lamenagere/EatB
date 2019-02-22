<template>
  <div class="resto-pref">
    <h1 class="container">{{title}}</h1>
    <div class="resto-list container">
      <RestoAdmin v-for="(r, index) in resto" :key="index" :resto="r"/>
    </div>
  </div>
</template>

<script>
import RestoAdmin from "./RestoAdmin.vue";

export default {
  data () {
    return {
      restos: [],
      maxRestos: 6,
      showAllRestos: false,
    }
  },
  props: ["resto", "title"],
  components: {
    RestoAdmin
  },
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
  columns: 2;
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
  .resto-list {
    columns: 2;
  }
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
  .resto-list {
    columns: 1;
  }
  h1 {
    font-size: 1.6em;
  }
}
</style>




