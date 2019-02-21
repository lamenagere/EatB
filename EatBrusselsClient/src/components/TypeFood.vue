<template>
  <div class="type-category container">
    <h1>Les types de cuisine préférés</h1>
    <div class="food-type">
      <div class="type">
        <router-link to="/routerlist/Asiatique" class="typeAsiatique">
            <h3>Asiatique</h3>
            <div class="img-type asian"></div>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/routerlist/Américaine" class="filtertype">
            <h3>Américaine</h3>
            <div class="img-type americain"></div>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/routerlist/Européenne" class="filtertype">
            <h3>Européenne</h3>
            <div class="img-type europeen"></div>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/routerlist/Belge" class="filtertype">
            <h3>Belge</h3>
            <div class="img-type oriental"></div>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/routerlist/Italienne" class="filtertype">
            <h3>Italienne</h3>
            <div class="img-type fastfood"></div>
        </router-link>
      </div>
      <div class="type">
        <router-link to="/routerlist/Healthy" class="filtertype">
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
      display: flex;
    flex-direction: column;
}
.food-type {
  max-width: 100vw;
  columns: 3;
  margin-bottom: 100px;
}
.type {
  display: flex;
  flex-direction: column;
  width: 320px;
  overflow: hidden; /* Fix for firefox and IE 10-11  */
  -webkit-column-break-inside: avoid; /* Chrome, Safari, Opera */
  page-break-inside: avoid; /* Firefox */
  break-inside: avoid; /* IE 10+ */
  break-inside: avoid-column;
  break-before: avoid;
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
    columns: 2;
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
    columns: 1;
  }
  .type {
    width: 100%;
  }
  .img-type {
    width: 100%;
  }
}
</style>
