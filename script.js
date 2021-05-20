
let itemsAdded = [];

function AddJellybeans() {
    let jellyName = "Jellybeans";
    let jellyPrice = 5.00;
    let newItem = {
        name: jellyName,
        price: jellyPrice
    }
    itemsAdded.push(newItem);
}
    //alert(itemsAdded[0].name);

function AddSneakers() {
    let sneakerName = "Sneakers";
    let sneakerPrice = 3.00;
    let newItem = {
        name: sneakerName,
        price: sneakerPrice
    }
    itemsAdded.push(newItem);
}

function AddMilkeyWay() {
    let milkeywayName = "Milkey Way";
    let milkeywayPrice = 2.00;
    let newItem = {
        name: milkeywayName,
        price: milkeywayPrice
    }
    itemsAdded.push(newItem);
}

function HersheyBar() {
    let itemName = "Hershey Bar";
    let itemPrice = 2.00;
    let newItem = {
        name: itemName,
        price: itemPrice
    }
    itemsAdded.push(newItem);
}

function AddHotTamales() {
    let itemName = "Hot Tamales";
    let itemPrice = 2.00;
    let newItem = {
        name: itemName,
        price: itemPrice
    }
    itemsAdded.push(newItem);
}

let salesTax = .06;
let total = 0;
function DisplayMyItems() {
    console.clear();
    //console._commandLineAPI.clear();
    for (let i = 0; i < itemsAdded.length; i++) {
        let nameDisp = itemsAdded[i].name
        let priceDisp = itemsAdded[i].price
        
        total += priceDisp;
        console.log(`${nameDisp}: $${priceDisp}`);
        
        //console.log('\n');
        //alert(`Grand Total: $${grandTotal}`);
    }
    
    console.log(`Your Total: $${total}`);
    // var GrandTotal = total.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
    // GrandTotal.getElementById('GrandTotal').innerHTML = GrandTotal;
}
