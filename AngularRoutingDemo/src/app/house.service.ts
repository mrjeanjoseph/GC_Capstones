import { House } from './house';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HouseService {
  houses: House[] = [
    {
      id: 0,
      type: "Ranch",
      floors: 1,
      bedroom: 5,
      baths: 1.5,
      sqfoot: 2500,
      price: 235000,
      img: "https://static01.nyt.com/images/2019/06/25/realestate/25domestic-zeff/a1c1a1a36c9e4ff8adcb958c4276f28d-jumbo.jpg"
    },
    {
      id: 2,
      type: "Duplex",
      floors: 2,
      bedroom: 4,
      baths: 1.5,
      sqfoot: 1950,
      price: 238900,
      img: "https://images1.apartmenthomeliving.com/i2/PBCwFVL-4525RlenxI7uNawwXxBCsN5_iVidNrjuccQ/113/image.jpg"
    },
    {
      id: 3,
      type: "Masion",
      floors: 3,
      bedroom: 6,
      baths: 2.5,
      sqfoot: 49800,
      price: 919000,
      img: "https://api.advancedhouseplans.com/uploads/plan-29922/29922-siesta-key-art-medium.jpg"
    },
    {
      id: 4,
      type: "Townhouse",
      floors: 2,
      bedroom: 4,
      baths: 1.5,
      sqfoot: 91950,
      price: 1219,
      img: "https://www.pmmag.com/ext/resources/Issues/2020/June/codes-1158983394.jpg?1591198614"
    },

  ]
  constructor() { }

  getAllHouses(): House[] {
    return this.houses;
  }

  getAllByType(type: string): House[] { // We are returning an array of houses.
    let result: House[] = []; // creating a temp variable to store the houses temporarily.
    this.houses.forEach((h: House) => { // using the arrow function
      if (h.type.toLowerCase() == type.toLowerCase()) {
        result.push();
      }

    })
    return result;
  }

  getHouseById(id:number): House{ //We are getting a single house - notice, there's no array.
    let result: House = {id: -1, type:"", floors:0, bedroom:0, baths:0, sqfoot:0, price:0, img:''};

    this.houses.forEach((h:House) => {
      if(h.id == id){
        result = h;
      }
    })
    return result;
  }
}
