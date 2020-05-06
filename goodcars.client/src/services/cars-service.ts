import axios from 'axios';
import ICar from '@/types/Car';

export default class CarService {
    API_URL = process.env.VUE_APP_API_URL;
    public async getAllCars(): Promise<ICar[]> {        
        let result = await axios.get(`${this.API_URL}/cars/`)
        return result.data;
    }
    public async addNewCar(car: ICar) {
        let result = await axios.post(`${this.API_URL}/cars/`, car)
        return result.data;
    }
    public async deleteCar(id: number) {
        let result = await axios.delete(`${this.API_URL}/cars/${id}`)
        return result.data;
    }
}