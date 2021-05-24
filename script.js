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
    //let result: Product[] = avgPrice;
    var counter = 0;
    var total = 0;
    avgPrice.forEach(function (ap) {
        total += ap.price;
        counter++;
    });
    return total / counter;
}
console.log(calcAverageProductPrice(product));
