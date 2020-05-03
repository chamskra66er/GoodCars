<template>
  <div class="about">
    <h1>Car list view</h1>
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
                then(result => this.myCars = result);
        }

    }
</script>

<style lang="scss">

</style>
