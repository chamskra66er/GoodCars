import axios from 'axios';
import ICar from '@/types/Car';

export default class CarService {
    API_URL = process.env.VUE_APP_API_URL;
    public async getAllCars(): Promise<ICar[]> {        
        let result = await axios.get(`${this.API_URL}/cars/`)
        return result.data;
    }
}