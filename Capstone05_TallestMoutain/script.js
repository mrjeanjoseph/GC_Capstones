"use strict";
exports.__esModule = true;
;
var mountain1 = {
    name: "Kilimanjaro",
    height: 19341
};
var mountain2 = {
    name: "Everest",
    height: 29029
};
var mountain3 = {
    name: "Denali",
    height: 20310
};
var mountains = [
    mountain1,
    mountain2,
    mountain3
];
function findNameOfTallestMountain(tallest) {
    var result = {
        name: "",
        height: 0
    };
    tallest.forEach(function (tm) {
        if (tm.height > result.height) {
            result = tm;
        }
    });
    return result.name;
}
console.log(findNameOfTallestMountain(mountains));
;
var p1 = {
    name: "iPhone 12 Pro Max",
    price: 1000
};
var p2 = {
    name: "Samsung Galaxy Note20",
    price: 1100
};
var product = [
    p1,
    p2
];
function calcAverageProductPrice(avgPrice) {
    var count = 0;
    var total = 0;
    avgPrice.forEach(function (ap) {
        total += ap.price;
        count++;
    });
    return total / count;
    //const arrAvg = product => product.reduce((a,b)=> a.price+b.price, 0) /product.length;
    //return arrAvg;
}
console.log(calcAverageProductPrice(product));
;
var i1 = {
    product: {
        name: "motor",
        price: 10.00
    },
    quantity: 10
};
var i2 = {
    product: {
        name: "sensor",
        price: 12.50
    },
    quantity: 4
};
var i3 = {
    product: {
        name: "LED",
        price: 1.00
    },
    quantity: 20
};
var inventory = [
    i1,
    i2,
    i3
];
function calcInventoryValue(totalPrice) {
    var total = 0;
    // totalPrice.forEach(function(p:InventoryItem){
    //     total+=(p.product.price * p.quantity);
    // });
    // return total;
    //or I can use a loop
    for (var i = 0; i < totalPrice.length; i++) {
        total += totalPrice[i].product.price * totalPrice[i].quantity;
    }
    return total;
}
console.log(calcInventoryValue(inventory));
