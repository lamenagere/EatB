
<template>
  <div class="resto">
    <router-link :to="'/restos/' + resto.restaurantID" class="filterrate resto">
      <img :src="resto.imageUrl" alt>
      <div class="info-resto">
        <div class="name-resto">
          <h3>{{resto.name}}</h3>
          <p>Cuisine {{resto.kitchenType}}</p>
        </div>
        <span class="stars">
          <i class="fas fa-star" :class="{yellow: resto.averageRating >= 1} "></i>
          <i class="fas fa-star" :class="{yellow: resto.averageRating >= 2} "></i>
          <i class="fas fa-star" :class="{yellow: resto.averageRating >= 3} "></i>
          <i class="fas fa-star" :class="{yellow: resto.averageRating >= 4} "></i>
          <i class="fas fa-star" :class="{yellow: resto.averageRating >= 5}"></i>
        </span>
      </div>
    </router-link>
  </div>
</template>

<script>
export default {
  props: ["resto"],
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
a{
  text-decoration: none;
  color: black;
}
.yellow {
  color: crimson;
}
.resto {
  width: 300px;
  text-align: left;
  break-inside: avoid;
  overflow: hidden;
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
  .resto {
    width: 100%;
    text-align: left;
    display: flex;
    flex-direction: row;
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