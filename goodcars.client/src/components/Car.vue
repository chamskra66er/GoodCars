<template>
    <div class="car-wrapper">
        <div class="car-title">
            {{car.title}}
        </div>
        <div class="car-name">
            {{car.name}}
        </div>
        <div class="car-price">
            {{car.price}}
        </div>                
        <div class="delete" @click="deleteCar(car.id)">
            x
        </div>
    </div>
</template>

<script lang="ts">
    import { Component, Prop, Vue } from 'vue-property-decorator';
    import ICar from '@/types/Car';
    import CarService from '../services/cars-service';

    const carService = new CarService();

    @Component({
        name: "Car",
        components: {}
    })
export default class Car extends Vue {
        @Prop({ required: true })
        car!: ICar;
        async deleteCar(id: number) {
            await carService.deleteCar(id);
            this.$emit('deleted', id);
        }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
    .car-wrapper {
        position: relative;
        margin: 0.8rem;
        padding: 0.4rem;
        border-radius: 1rem;
        background-color:#fafafa;
        box-shadow: 0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24);
    }
    .car-title{
        font-size:1.2rem;
        font-weight:bold;
    }
    .car-name{
        color:#333;
    }
    .car-price {
        color: #333;
    }
    .delete{
        position:absolute;
        top:5px;
        right:9px;
        font-size:0.8rem;
        font-weight:bold;
        color:#CE3355;
        cursor:pointer;
    }
</style>