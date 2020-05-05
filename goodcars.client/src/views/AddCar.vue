<template>
    <div class="add-car-wrapper">
        <h1>Add Car</h1>
        <div class="add-car-form">
            <ul class="new-car">
                <li>
                    <label for="title">Car brand</label>
                    <input type="text" id="title" v-model="car.title" />
                </li>
                <li>
                    <label for="name">Car name</label>
                    <input type="text" id="name" v-model="car.name" />
                </li>
                <li>
                    <label for="price">Car price</label>
                    <input type="text" id="price" v-model="car.price" />
                </li>
                <li>
                    <label for="power">Car power</label>
                    <input type="text" id="power" v-model="car.power" />
                </li>
                <li>
                    <label for="datemade">Car date made</label>
                    <input type="text" id="datemade" v-model="car.dateMade" />
                </li>
                <li>
                    <label for="mileage">Car mileage</label>
                    <input type="text" id="mileage" v-model="car.mileage" />
                </li>
            </ul>
            <button :disabled="isButtonDisabled" @click="addCar">Add Car</button>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';
import ICar from '@/types/Car';
import CarService from '../services/cars-service';

    const carService = new CarService();

    @Component({
        name: "AddCar",
        components: {}
    })
    export default class AddCar extends Vue {
        car: ICar = {
            title: "",
            name: "",
            price: "",
            power: "",
            dateMade: "",
            mileage: ""
        };
        get isButtonDisabled() {
            return this.car.title === "" ||
                this.car.name === "" ||
                this.car.price === "" ||
                this.car.power === "" ||
                this.car.dateMade === "" ||
                this.car.mileage===""
        }
        addCar() {
            carService.addNewCar(this.car);
        }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
    .new-car{
        list-style:none;
        padding:0;
        margin:0;
    }
   input{
       height:1.8rem;
       margin-bottom:1.2rem;
       font-size:1.1rem;
       line-height:1.3rem;
       padding:0.2rem;
       calor:#555;
   }
   label{
       font-weight:bold;
       display:block;
       margin-bottom:0.3rem;
   }
</style>