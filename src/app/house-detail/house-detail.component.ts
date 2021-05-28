import { HouseService } from './../house.service';
import { House } from './../house';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-house-detail',
  templateUrl: './house-detail.component.html',
  styleUrls: ['./house-detail.component.css']
})
export class HouseDetailComponent implements OnInit {
  house: House = {
    id: -1,
    type: "",
    floors: 0,
    bedroom: 0,
    baths: 0,
    sqfoot: 0,
    price: 0,
    img: ""
  }
  constructor(private houseservice: HouseService, private route: ActivatedRoute) { } // Dependency injection here
  //Also notice the activate route and the interface

  ngOnInit(): void {
    const routeParams = this.route.snapshot.paramMap;
    let id: number = Number(routeParams.get("id"));

    this.house = this.houseservice.getHouseById(id);
  }

}
