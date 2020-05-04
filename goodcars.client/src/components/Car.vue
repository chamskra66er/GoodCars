<template>
    <div class="car-wrapper">
        {{car.title}}
    </div>
</template>
<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import ICar from '@/types/Car';

    @Component({
        name: 'Car',
        components: {}
    })
    export default class Car extends Vue {
    @Prop({required:true})
    car:ICar
    }
</script>
<style scoped lang="scss">
    .car-wrapper{
        margin:0.8rem;
        padding:0.4rem;
        border: 1px solid #555;
    }
</style>