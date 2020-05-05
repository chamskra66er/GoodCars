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
    </div>
</template>

<script lang="ts">
    import { Component, Prop, Vue } from 'vue-property-decorator';
    import ICar from '@/types/Car'

    @Component({
        name: "Car",
        components: {}
    })
export default class Car extends Vue {
        @Prop({ required: true })
        car!: ICar;
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
    .car-wrapper {
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
</style>