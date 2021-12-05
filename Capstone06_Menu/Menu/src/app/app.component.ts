import { MenuItem } from './menu-item';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Menu';

  PizzaMenu: MenuItem[] = [    
    {
      item: "Boullion",
      category: "Dinner",
      price: 25.99,
      description: "Tasty delicious Haitian stew"
    },
    {
      item: "Soup Joumou",
      category: "Dinner",
      price: 31.99,
      description: "Tasty delicious Soup Joumou"
    },
    {
      item: "Haitian Fritay",
      category: "Dinner",
      price: 13.99,
      description: "Tasty delicious Ceasar Salad"
    },
    {
      item: "Chicken Fingers",
      category: "Dinner",
      price: 11.99,
      description: "Tasty delicious dinner"
    },
    {
      item: "Pizza",
      category: "Dinner",
      price: 11.99,
      description: "Tasty delicious dinner"
    },
    {
      item: "Wings",
      category: "Sides",
      price: 8.99,
      description: "Tasty delicious dinner"
    },
    {
      item: "Breadsticks",
      category: "Sides",
      price: 4.99,
      description: "Tasty delicious dinner"
    },
    {
      item: "Ceasar Salad",
      category: "Salads",
      price: 5.99,
      description: "Tasty delicious Ceasar Salad"
    },
  ];
  SortByCategory():MenuItem[]{
    let result: MenuItem[] = this.PizzaMenu.sort((a,b) => (a.category > b.category ? 1:-1));


    // let result: MenuItem[] = sorting;
    // for (let i: number = 0; i>result.length; i++){
    //   if(i == result.length-1){
    //     break;
    //   }
    //   if(result[i].category>result[i+1].category){
    //     let temp: MenuItem = result[i+1];
    //     result[i+1] = result[i];
    //     result[i] = temp;
    //     i=-1;
    //   }
    return result;
  };  
}
