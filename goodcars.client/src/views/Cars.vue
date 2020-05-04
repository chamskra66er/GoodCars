<template>
  <div class="cars-container">
    <h1>Car list view</h1>
      <div v-if="myCars.length">
          <div v-for="car in myCars" :key="car.id">
              {{car.title}} - {{car.name}}
          </div>
      </div>
  </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import ICar from '@/types/Car';
    import CarService from '../services/cars-service';

    const carService = new CarService();

    @Component({
        name: 'MyCars',
        components: {}
    })
    export default class MyCars extends Vue {
        myCars: ICar[] = [];
        get carCount() {
            return this.myCars.length;
        }
        created() {
            carService.getAllCars().
                then(result => this.myCars = result)
                .catch(err=>console.error(err));
        }

    }
</script>

<style lang="scss">

</style>
