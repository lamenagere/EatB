<template>
  <div class="type-category container">
    <h1>Les types de cuisine préférés</h1>
    <div class="food-type">
      <div class="type">
        <router-link to="/routerlist" class="filtertype">
          <a href>
            <h3>Asiatique</h3>
            <div class="img-type asian"></div>
          </a>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/" class="filtertype">
          <a href>
            <h3>Américaine</h3>
            <div class="img-type americain"></div>
          </a>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/" class="filtertype">
          <a href>
            <h3>Européene</h3>
            <div class="img-type europeen"></div>
          </a>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/" class="filtertype">
            <h3>Belge</h3>
            <div class="img-type oriental"></div>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/" class="filtertype">
            <h3>Italienne</h3>
            <div class="img-type fastfood"></div>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/" class="filtertype">
            <h3>Healthy</h3>
            <div class="img-type healthy"></div>
        </router-link>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "TypeFood",
  props: {
    msg: String
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
a {
  text-decoration: none;
  color: black;
}
.food-type {
  max-width: 100vw;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  margin-bottom: 100px;
}
.type {
  display: flex;
  flex-direction: column;
  width: 320px;
}
.img-type {
  width: 320px;
  height: 220px;
  background: url(~@/assets/img/asian.jpg) center/cover;
}
.americain {
  background: url(~@/assets/img/burgerr.jpg) center/cover;
}
.fastfood {
  background: url(~@/assets/img/ital.jpg) center/cover;
}
.healthy {
  background: url(~@/assets/img/health.jpg) center/cover;
}
.europeen {
  background: url(~@/assets/img/euro.jpg) center/cover;
}
.oriental {
  background: url(~@/assets/img/orient.jpg) center/cover;
}
h1 {
  font-family: "Roboto", sans-serif;
  text-align: left;
  margin-bottom: 20px;
  margin-top: 70px;
}
h3 {
  margin: 25px 0 10px 0;
}

@media screen and (max-width: 1150px) {
  h1 {
    margin-bottom: 30px;
    margin-top: 70px;
  }
  .food-type {
    max-width: 100vw;
    padding-bottom: 40px;
  }
  .type {
    width: 300px;
  }
  .img-type {
    width: 300px;
    height: 200px;
  }
  .food-type {
    margin-bottom: 50px;
  }
}
@media screen and (max-width: 770px) {
  h1 {
    font-size: 1.6em;
  }
  .food-type {
    max-width: 100vw;
  }
  .type {
    width: 100%;
  }
  .img-type {
    width: 100%;
  }
}
</style>
