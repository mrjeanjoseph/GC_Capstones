import { HouseService } from './../house.service';
import { House } from './../house';
import { Component, OnInit } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap'; // added here

@Component({
  selector: 'app-houselist',
  templateUrl: './houselist.component.html',
  styleUrls: ['./houselist.component.css'],
  providers: [NgbCarouselConfig] // added here
})

export class HouselistComponent implements OnInit {

  constructor(private houseservice: HouseService, config: NgbCarouselConfig) {
    config.interval = 1000;
    config.wrap = false;
    config.keyboard = false;
    config.pauseOnHover = true;
  }
  houses: House[] = [];

  searchTerm = "";

  getHouseResult(): House[] {
    if (this.searchTerm == "") {
      return this.houses;
    }
    else {
      return this.houseservice.getAllByType(this.searchTerm);
    }
  }

  ngOnInit(): void { //The house gets assigned here
    this.houses = this.houseservice.getAllHouses();
  }

  searchHouseByType(type: string): void {

    this.searchTerm = type; // to make sure we get data from the parameters
  }

}
