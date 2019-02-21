<template>
    <div>
        <h2>Ajouter un restaurant:</h2>
        <form class="form">
            <div>
            <label for="kitchenType">Type de cuisine </label>
            <!-- <select id="kitchenType" v-model="restaurant.kitchenTypes">
                <option :value="kt.kitchenTypeID" v-for="kt in allKitchenTypes" :key="kt.kitchenTypeID">{{kt.kitchenTypeLabel}}</option>
            </select> -->
            <div  v-for="kt in allKitchenTypes" :key="kt.kitchenTypeID">
                <input type="checkbox" :id="kt.kitchenTypeLabel" :value="kt.kitchenTypeID" v-model="restaurant.kitchenTypes">
                <label :for="kt.kitchenTypeLabel">{{kt.kitchenTypeLabel}}</label>
            </div>
            {{restaurant.kitchenTypes}}
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
                <input id="name" type="text" v-model="restaurant.zipCode">
            </div>
<<<<<<< HEAD
            <div>
                <label for="image">Image du restaurant</label>
                <input id="image" type="text" v-model="restaurant.imageUrl">
            </div>
            <button @click="post()">Ajouter ce restaurant à la liste</button>
=======
            <button @click.prevent="post()">Ajouter ce restaurant à la liste</button>
>>>>>>> e8fcd9bef290d143f230d08d6c5135eb3bdcbd80
        </form>
    </div>
</template>

<script>
import axios from "axios";
export default {
    data: function() {
        return {
        restaurant: {
            kitchenTypes: [],
            name: '',
            address:'',
            zipCode:'',
<<<<<<< HEAD
            imageUrl:'',
            }
=======
            },
        allKitchenTypes: [{
            kitchenTypeID: 1,
            kitchenTypeLabel: "Belge"
        },
        {
            kitchenTypeID: 2,
            kitchenTypeLabel: "Asiatique"
        }],
>>>>>>> e8fcd9bef290d143f230d08d6c5135eb3bdcbd80
        }
    },
    created(){
        //appeler URL qui renvoie un JSON de tous les kitchentypes
        //et les mettre dans allKitchenTypes

        // axios
        // .get("http://localhost:63980/api/restaurants?kitchenType=" + this.$route.params.kitchenType)
        //     .then(response => {
        //         this.restoPerKitchenType = response.data  
        //     })
    },
    methods: {
        post(){
            axios.post("http://localhost:63980/api/Restaurants", this.restaurant)
                .then(response => {
                    this.restaurant.kitchenTypes = [''];
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
