<template>
  <div class="fullwidth">
    <div class="img-head-resto"></div>
    <div class="container">
      <div class="resto">
        <div class="resto__bloc">
          <div class="resto__infos">
            <h2>{{resto.name}}</h2>
            <p class="tags">Cuisine italienne</p>
            <p>{{resto.address}}</p>
          </div>
        </div>
        <div class="resto__menu" v-sticky="{ zIndex: 10, stickyTop: 0, disabled: false}">
          <RestoMenu/>
          <div class="basket">
            <div class="order">Réserver une table</div>
          </div>
        </div>
        <div class="resto__list">
          <!-- DEBUT MENU ITEM -->
          <div class="menu_item">
            <div class="menu_title">
              <h4>Entrées</h4>
              <!-- <p>Toutes nos entrées sont servies avec du pain italien bla bla bla</p> -->
            </div>
            <div class="plat_container">
              <!-- DEBUT LISTE PLATS -->
              <div class="plat">
                <p class="price">10,50€</p>
                <h5>Bruschetta</h5>
                <p>Pain à la tomate, ail et basilic</p>
              </div>
              <div class="plat">
                <p class="price">8,00€</p>
                <h5>Soupe aux asperges</h5>
                <p>Soupe aux asperges et à la crème</p>
              </div>
              <div class="plat">
                <p class="price">9,50€</p>
                <h5>Croquette de fromage</h5>
                <p>Croquette servie avec une salade</p>
              </div>
              <div class="plat">
                <p class="price">11,50€</p>
                <h5>Duo délice</h5>
                <p>Surprise du chef</p>
              </div>
              <!-- FIN LISTE PLATS -->
            </div>
          </div>
          <!-- FIN MENU ITEM -->
          <!-- MENU ITEM COPIE -->
          <div class="menu_item">
            <div class="menu_title">
              <h4>Menu</h4>
            </div>
            <div class="plat_container">
              <!-- DEBUT LISTE PLATS -->
              <div class="plat">
                <p class="price">16,50€</p>
                <h5>Pâtes à la Vongole</h5>
                <p>Tagliatelles aux fruits de mer</p>
              </div>
              <div class="plat">
                <p class="price">16,50€</p>
                <h5>Risotto à la truffe</h5>
                <p>Risotto aux champignons et truffe</p>
              </div>
              <div class="plat">
                <p class="price">14,50€</p>
                <h5>Tagliatelle au pesto</h5>
                <p>Tagliatelles au pesto, parmesan</p>
              </div>
              <div class="plat">
                <p class="price">13,50€</p>
                <h5>Penne Arabiata</h5>
                <p>Penne sauce tomate aux poivrons</p>
              </div>
              <div class="plat">
                <p class="price">17,50€</p>
                <h5>Trio spécial</h5>
                <p>Trio de pâtes, spécialité du chef</p>
              </div>
              <div class="plat">
                <p class="price">16,50€</p>
                <h5>Risotto à la truffe</h5>
                <p>Risotto aux champignons et truffe</p>
              </div>
                            <div class="plat">
                <p class="price">15,00€</p>
                <h5>Lasagne</h5>
                <p>Lasagne du chef</p>
              </div>
              <div class="plat">
                <p class="price">16,50€</p>
                <h5>Canneloni</h5>
                <p>Canneloni aux épinards et à la ricotta</p>
              </div>
              <!-- FIN LISTE PLATS -->
            </div>
          </div>
          <!-- FIN MENU ITEM COPIE -->
        </div>
      </div>
    </div>
  </div>
</template>

<script>
// @ is an alias to /src
import VueSticky from "vue-sticky";
import RestoMenu from "@/components/RestoMenu.vue";
import axios from "axios";

export default {
  name: "home",
  data() {
    return {
      resto: []
    };
  },
  components: {
    RestoMenu
  },
  directives: {
    sticky: VueSticky
  },
  created() {
    axios
      .get("http://localhost:63980/api/restaurants/" + this.$route.params.id)
      .then(response => {
        this.resto = response.data;
      });
  }
};
</script>

<style scoped lang="scss">
.img-head-resto {
  background: url("~@/assets/img/daclaudio.jpg") center/cover;
  height: 500px;
  overflow: hidden;
}
.fullwidth {
  width: 100vw;
  background: rgb(243, 243, 243);
  padding-bottom: 80px;
}
.resto {
  margin: 0 auto;
  width: 1025px;
  font-family: "Open Sans";
  &__image img {
    width: 400px;
  }
  &__bloc {
    display: flex;
  }
  &__infos {
    text-align: left;
    & h2 {
      margin-bottom: 0px;
      font-size: 50px;
    }
    & .tags {
      font-size: 1em;
      color: grey;
      font-style: italic;
    }
  }
  &__menu {
    display: flex;
    justify-content: space-between;
    position: relative;
    border-top: 2px rgb(218, 218, 218) solid;
    border-bottom: 2px rgb(218, 218, 218) solid;
  }
}
.basket {
  width: 300px;
  position: absolute;
  top: 0;
  right: 0;
  text-align: center;
}
.plat {
  display: flex;
  flex-direction: column;
  width: 340px;
  margin-bottom: 20px;
  text-align-last: left;
  background: white;
  padding: 15px 10px;
  position: relative;
  & h5,
  p {
    margin: 0 0 10px 0;
  }
  & h5 {
    font-size: 16px;
    color: rgb(48, 48, 48);
  }
  & p {
    color: rgb(138, 138, 138);
  }
  & .price {
    position: absolute;
    right: 10px;
  }
}
.plat_container {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  width: 700px;
}
.menu_title {
  text-align: left;
}
.order {
  background: crimson;
  color: #ffffff;
  height: 40px;
  line-height: 40px;
  cursor: pointer;
}
.selection {
  height: 200px;
}
h4 {
  font-size: 1.3em;
}
@media screen and (max-width: 770px) {
  .img-head-resto {
    height: 300px;
  }
}
</style>
