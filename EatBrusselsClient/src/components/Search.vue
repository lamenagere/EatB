<template>
    <div class="fullwidth">
    <div class="container">
      <div class="head-intro">
        <h1 class="title">Les meilleurs restaurants près de chez vous.</h1>
        <div class="search">
          <input type="text" name="adress" id class="search-bar" placeholder="Votre code postal" v-model="message">
          <router-link :to="'/routerzip/'+message" class="filterzipcodee">
          <div class="loupe-bg">
            <i class="fas fa-search"></i>
          </div>
          </router-link>
        </div>
      </div>
    </div>
    </div>
</template>

<script>
export default {
  name: "zipCode",
  data(){
      return {
          message:null
      }
  },
  props: {
    msg: String
  }
}
</script>

<style>
.title {
    font-family: "Roboto", sans-serif;
    color: white;
    text-align: left;
    margin: 0;
    padding-top: 150px;
    width: 450px;
}
.img-head {
    z-index: -2;
}
.search {
    margin-top: 20px;
    display: flex;
    align-items: center;
}
.search-bar {
    background: white;
    padding: 15px;
    border: none;
    height: 40px;
    width: 440px;
    margin: 0;
    left: 0;
}
.loupe-bg {
    cursor: pointer;
    background: crimson;
    height: 40px;
    width: 45px;
    display: flex;
    justify-content: center;
    align-items: center;
}
.fa-search {
    color: white;
}
.head-intro {
    height: 450px;
    max-width: 100vw;
}
.fullwidth {
    max-width: 100vw;
    background: url("~@/assets/img/head-img.jpg") center/cover;
}

@media screen and (max-width: 770px) {
    .title {
        width: 100%;
    }
}
</style>
