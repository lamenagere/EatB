
<template>
  <div class="resto">
    <router-link to="/" class="filterrate">
    <a href>
      <img src="@/assets/img/balmo.jpg" alt>
      <div class="info-resto">
        <div class="name-resto">
          <h3>{{name}}</h3>
          <p>Cuisine {{type}}</p>
        </div>
        <span class="stars">
          <i class="fas fa-star"></i>
          <i class="fas fa-star"></i>
          <i class="fas fa-star"></i>
          <i class="fas fa-star"></i>
          <i class="fas fa-star"></i>
        </span>
      </div>
    </a>
    </router-link>
  </div>
</template>

<script>
export default {
  props: ["name", "type"]
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
a{
  text-decoration: none;
  color: black;
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
@media screen and (max-width: 770px) {
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