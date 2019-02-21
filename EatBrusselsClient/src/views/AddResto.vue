<template>
    <div class="form-resto  container">
        <h1>Ajouter un restaurant</h1>
        <form class="form">
            <div>
            <label for="kitchenType" class="label-title">Type de cuisine </label>
            <!-- <select id="kitchenType" v-model="restaurant.kitchenTypes">
                <option :value="kt.kitchenTypeID" v-for="kt in allKitchenTypes" :key="kt.kitchenTypeID">{{kt.kitchenTypeLabel}}</option>
            </select> -->
            <div class="column-type">
            <div  v-for="kt in allKitchenTypes" :key="kt.kitchenTypeID" >
                <input type="checkbox" :id="kt.kitchenTypeLabel" :value="kt.kitchenTypeID" v-model="restaurant.kitchenTypes">
                <label :for="kt.kitchenTypeLabel" class="typel">{{kt.kitchenTypeLabel}}</label>
            </div></div>
            </div>
            <div class="flex-label">
                <label for="name" class="label-title">Nom du restaurant </label>
                <input id="name" type="text" v-model="restaurant.name" class="input-l" required>
            </div>
            <div class="flex-label">
                <label for="name" class="label-title">Addresse du restaurant </label>
                <input id="name" type="text" v-model="restaurant.address" class="input-l" required>
            </div>
            <div class="flex-label">
                <label for="name" class="label-title">Code postal</label>
                <input id="name" type="text" v-model="restaurant.zipCode" class="input-l" required>
            </div>
            <div class="flex-label">
                <label for="image" class="label-title">Image du restaurant</label>
                <input id="image" type="text" v-model="restaurant.imageUrl" class="input-l" required>
            </div>
            <button @click.prevent="post()">Ajouter ce restaurant à la liste</button>
        </form>
    </div>
</template>

<script scoped>
import axios from "axios";
export default {
    data: function() {
        return {
        restaurant: {
            kitchenTypes: [],
            name: '',
            address:'',
            zipCode:'',
            imageUrl:'',
            },
        allKitchenTypes: [{
            kitchenTypeID: 1,
            kitchenTypeLabel: "Asiatique"
        },
        {
            kitchenTypeID: 2,
            kitchenTypeLabel: "Européenne"
        },
                {
            kitchenTypeID: 2,
            kitchenTypeLabel: "Italienne"
        },
                {
            kitchenTypeID: 2,
            kitchenTypeLabel: "Américaine"
        },
                {
            kitchenTypeID: 2,
            kitchenTypeLabel: "Belge"
        },
                        {
            kitchenTypeID: 2,
            kitchenTypeLabel: "Healthy"
        }],
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
.typel{
    margin-left: 5px;
}
.column-type{
    columns: 2;
}
button{
    background: crimson;
    color: white;
    padding: 10px 15px;
    border: none;
    margin: 20px 0 60px 0;
    border-radius: 5px;
}
.form div {
    margin: 10px 0;
}
.form-resto{
    text-align: left;
}
h1{
    margin: 60PX 0 40px 0;
}
.label-title{
    font-weight: bold;
    color: rgb(94, 94, 94);
    margin: 5px 0 5px 0;
}
.flex-label{
    display: flex;
    flex-direction: column;
}
.input-l{
    width: 500px;
    height: 35px;
    border-radius: 5px;
    border: 1px solid crimson;
    background: white;
}
form{
    width:  700px;
}
</style>
