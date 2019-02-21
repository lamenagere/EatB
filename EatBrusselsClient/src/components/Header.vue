<template>
  <div class="header">
    <nav class="container">
      <router-link to="/" class="logo">
        <i class="fas fa-hamburger"></i> Eat.brussels
      </router-link>
      <ul class="connex">
        <li>
          <router-link to="/addresto">Ajouter un restaurant</router-link>
        </li>
        <li>
          <a href="#" class="link-menu">Se connecter</a>
        </li>
        <li>
          <a href="#" class="link-menu">S'inscrire</a>
        </li>
      </ul>
      <Slide right class="burger">
        <a id="home" href="#">
          <span>Se connecter</span>
        </a>
      </Slide>
    </nav>
  </div>
</template>

<script>
import { Slide } from "vue-burger-menu";
export default {
  components: {
    Slide
  }
};
</script>

<style lang="scss">
/* nav */
a {
  text-decoration: none;
  color:white;
}
nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
  color: white;
  font-family: "Open Sans";
}
// burger css
.burger {
  position: absolute;
  right: 0;
  display: none;
}
.bm-burger-button {
  top: -8px;
  height: 18px;
  width: 22px;
}
.bm-burger-bars {
  background-color: white;
  border-radius: 2px;
}
.line-style {
  position: absolute;
  height: 2px;
  left: 0;
  right: 0;
}

.logo {
  font-family: "Roboto", sans-serif;
  font-weight: bold;
  font-size: 17px;
  text-decoration: none;
  color: white;
  line-height: 50px;
}
ul {
  display: flex;
}
li {
  list-style: none;
}
.link-menu {
  color: white;
  text-decoration: none;
  margin-left: 25px;
}
/* head */
.header {
  margin: 0;
  position: relative;
  max-width: 100vw;
  height: 50px;
  overflow: hidden;
  background: rgb(32, 32, 32);
  // opacity: 0.8;
}

@media screen and (max-width: 1150px) {
  .head-intro {
    margin-top: 0;
  }
}
@media screen and (max-width: 770px) {
  .title {
    font-size: 1.6em;
  }
  .search-bar {
    width: 85%;
  }
  .head-intro {
    width: 90%;
  }
  .burger {
    display: block;
  }
  .connex {
    display: none;
  }
}
</style>
