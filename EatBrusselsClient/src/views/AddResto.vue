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
<div class="horaire">
                <div class="flex-label horaire-flex">
                    <label for="name" class="label-title">Heure d'ouverture</label>
                    <input id="name" type="text" v-model="restaurant.openingHour" class="input-h" required placeholder="00:00">
                </div>
                <div class="flex-label horaire-flex">
                    <label for="name" class="label-title">Heure de fermeture</label>
                    <input id="name" type="text" v-model="restaurant.closingHour" class="input-h" required placeholder="00:00">
                </div>
</div>
            <div class="flex-label">
                <label for="image" class="label-title">Image du restaurant (copier l'URL (séparer par une virgule si plusieurs urls))</label>
                <input id="image" type="text" v-model="restaurant.images" class="input-l" required placeholder="http://...">
            </div>
            <button @click.prevent="post()">Ajouter ce restaurant à la liste</button>
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
            images:[],
            openingHour: '',
            closingHour: '',
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
            kitchenTypeID: 3,
            kitchenTypeLabel: "Italienne"
        },
                {
            kitchenTypeID: 4,
            kitchenTypeLabel: "Américaine"
        },
                {
            kitchenTypeID: 5,
            kitchenTypeLabel: "Belge"
        },
                        {
            kitchenTypeID: 6,
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
            axios.post("http://labo-team4-bf.azurewebsites.net/api/Restaurants", this.restaurant)
                .then(response => {
                    this.restaurant.kitchenTypes = [''];
                    this.restaurant.name = '';
                    this.restaurant.address = '';
                    this.restaurant.zipCode = '';
                    this.restaurant.imageUrl = '';
                });alert("Restaurant ajouté");
        }
    }

}
</script>

<style scoped>
.horaire{
    display: flex;
    width: 500px;
}
.horaire-flex{
    display: flex; 
    flex-direction: row;
}
.input-h{
    width: 200px;
    height: 32px;
    border-radius: 5px;
    border: 1px solid crimson;
    background: white;
    margin-right: 20px;
}
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
    cursor: pointer;
}
.form div {
    margin: 8px 0;
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
    margin: 4px 0 4px 0;
}
.flex-label{
    display: flex;
    flex-direction: column;
}
.input-l{
    width: 500px;
    height: 32px;
    border-radius: 5px;
    border: 1px solid crimson;
    background: white;
}
form{
    width:  700px;
}
input{
    padding: 0 10px;
}

@media screen and (max-width: 770px) {
    form{
    width:  100%;
}
    .horaire{
    width: 100%;
    flex-direction: column;
    }
    .input-l{
        max-width: 100%;
    }
    .input-h{
    width: 100%;
}
}
</style>
