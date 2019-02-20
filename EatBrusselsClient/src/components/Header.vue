<template>
  <div class="header">
    <nav class="container">
      <router-link to="/" class="logo">
        <i class="fas fa-hamburger"></i> Eat.brussels
      </router-link>
      <ul class="connex">
        <li>
          <a href="#" class="link-menu">Se connecter</a>
        </li>
        <li>
          <a href="#" class="link-menu">S'inscrire</a>
        </li>
      </ul>
    </nav>
  </div>
</template>

<script>
export default {
  components: {
    }
};
</script>

<style lang="scss">
/* nav */
nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
  color: white;
  font-family: 'Open Sans'
}
.burger {
  position: absolute;
  right: 0;
  display: none;
}
.bm-burger-button {
  top: -40px;
  right: 5px;
}
.logo {
  font-family: "Roboto", sans-serif;
  font-weight: bold;
  font-size: 17px;
  text-decoration: none;
  color:white;
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
    margin-top: 150px;
  }
  .burger {
    display: block;
  }
  .connex {
    display: none;
  }
}
</style>
