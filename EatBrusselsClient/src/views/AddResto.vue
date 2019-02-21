<template>
    <div>
        <h2>Ajouter un restaurant:</h2>
        <form class="form">
            <div>
            <label for="kitchenType">Type de cuisine </label>
            <select id="kitchenType" v-model="restaurant.kitchenType">
                <option value="asiatique">Asiatique</option>
                <option value="américaine">Américaine</option>
                <option value="européenne">Européenne</option>
                <option value="belge">Belge</option>
                <option value="italienne">Italienne</option>
                <option value="healthy">Healthy</option>
            </select>
            </div>
            <div>
                <label for="name">Nom du restaurant </label>
                <input id="name" type="text" v-model="restaurant.name">
            </div>
            <div>
                <label for="name">Addresse du restaurant </label>
                <input id="name" type="text" v-model="restaurant.address">
            </div>
            <div>
                <label for="name">Code postal communal </label>
                <input id="name" type="number" v-model="restaurant.zipCode">
            </div>
            <div>
                <label for="image">Image du restaurant</label>
                <input id="image" type="text" v-model="restaurant.imageUrl">
            </div>
            <button @click="post()">Ajouter ce restaurant à la liste</button>
        </form>
    </div>
</template>

<script>
import axios from "axios";
export default {
    data: function() {
        return {
        restaurant: {
            kitchenType: '',
            name: '',
            address:'',
            zipCode:'',
            imageUrl:'',
            }
        }
    },
    methods: {
        post(){
            axios.post("http://localhost:63980/api/Restaurants", this.restaurant)
                .then(response => {
                    this.restaurant.kitchenType = '';
                    this.restaurant.name = '';
                    this.restaurant.address = '';
                    this.restaurant.zipCode = '';
                    this.restaurant.imageUrl = '';
                })
        }
    }

}
</script>

<style>
.form div {
    margin: 10px 0;
}
</style>
