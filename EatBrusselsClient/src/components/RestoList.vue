<template>
  <div>
    <Resto v-for="(r, index) in resto" :key="index" :name="r.name"  />
  </div>
</template>

<script>
import Resto from "./Resto.vue"
import axios from "axios";

export default {
  data(){
    return {
      resto : []
    }
  },
  components: {
    Resto 
  },
  created(){
    axios.get('http://localhost:63980/api/restaurants')
    .then(response => {
      //console.log(JSON.stringify(response.data))
      this.resto=response.data
    })
  }
};
</script>







<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
.resto-pref {
  background: rgb(238, 238, 238);
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
.resto {
  width: 300px;
  text-align: left;
}
img {
  width: 100%;
}
h3 {
  margin: 8px 0 5px 0;
  font-size: 1.1em;
}
p {
  margin: 0 0 25px 0;
}
.info-resto {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.stars {
  font-size: 15px;
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
  .resto-list {
    display: flex;
    flex-direction: column;
  }
  .resto {
    width: 100%;
    text-align: left;
    display: flex;
    justify-content: flex-start;
    align-items: center;
    margin-bottom: 25px;
  }
  img {
    width: 60%;
    margin-right: 15px;
  }
  h3 {
    font-size: 1em;
  }
  .info-resto {
    display: flex;
    flex-direction: column;
    justify-content: flex-start;
    align-items: flex-start;
  }
  .stars {
    font-size: 13px;
  }
}
</style>
