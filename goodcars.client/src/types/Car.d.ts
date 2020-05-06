import CarOwner from '@/types/CarOwner';

export default interface ICar {
	id: number;
	title: string;
	name: string;
	power: string;
	price: string;
	dateMade: string;
	mileage: string;
	//carOwner: CarOwner;
}
