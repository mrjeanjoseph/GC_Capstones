import { HouseService } from './../house.service';
import { House } from './../house';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-houselist',
  templateUrl: './houselist.component.html',
  styleUrls: ['./houselist.component.css']
})
export class HouselistComponent implements OnInit {

  constructor(private houseservice: HouseService) { }
  houses: House[] = [];

  searchTerm = "";

  getHouseResult(): House[]{
    if(this.searchTerm == ""){
      return this.houses;
    }
    else{
      return  this.houseservice.getAllByType(this.searchTerm);
    }
  }

  ngOnInit(): void { //The house gets assigned here
    this.houses = this.houseservice.getAllHouses();
  }

  searchHouseByType(type: string): void {
    //console.log(type);
    this.searchTerm = type; // to make sure we get data from the parameters
  }

}
