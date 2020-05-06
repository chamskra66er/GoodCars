<template>
  <div class="cars-container">
    <h1>Car list view</h1>
      <div v-if="myCars.length">
          <car @deleted="getAllCars"
               :car="car" 
               v-for="car in myCars" 
               :key="car.id">
          </car>
      </div>
  </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import ICar from '@/types/Car';
    import CarService from '../services/cars-service';
    import Car from '@/components/Car.vue';

    const carService = new CarService();

    @Component({
        name: 'MyCars',
        components: { Car }
    })
    export default class MyCars extends Vue {
        myCars: ICar[] = [];
        get carCount() {
            return this.myCars.length;
        }
        getAllCars() {
            carService.getAllCars().
                then(result => this.myCars = result)
                .catch(err => console.error(err));
        }
        created() {
            this.getAllCars();
        }

    }
</script>

<style lang="scss">

</style>
