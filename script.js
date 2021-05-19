
let itemsAdded = [];

function AddJellybeans(){
   let jellyName = "Jellybeans";
   let jellyPrice = 5.00;
   let newItem = {
       name: jellyName,
       price: jellyPrice
   }
   itemsAdded.push(newItem);
}
function AddSneakers(){
    let sneakerName = "Sneakers";
    let sneakerPrice = 3.00;
    let newItem = {
        name: sneakerName,
        price: sneakerPrice
    }
    itemsAdded.push(newItem);
 }

 function AddMilkeyWay(){
     let milkeywayName = "MilkeyWay";
     let milkeywayPrice = 2.00;
     let newItem = {
         name: milkeywayName,
         price: milkeywayPrice
     }
     itemsAdded.push(newItem);
  }
  let sum = 0;
function DisplayMyItems(){
    for(let i=0; i<itemsAdded.length; i++) {
        console.log(itemsAdded[i].name);
        sum =+ itemsAdded[i].price
        console.log(sum);
    }
}

console.log(sum);
