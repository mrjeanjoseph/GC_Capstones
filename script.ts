export{}

//TALLEST MOUNTAIN
interface TallestMountain {
    name: string;
    height: number;
};

let mountain1: TallestMountain = {
    name: "Kilimanjaro",
    height: 19341
};

let mountain2: TallestMountain = {
    name: "Everest",
    height: 29029
};

let mountain3: TallestMountain = {
    name: "Denali",
    height: 20310
};

let mountains: TallestMountain[] = [
    mountain1,
    mountain2,
    mountain3
];

function findNameOfTallestMountain(tallest: TallestMountain[]): string {
    let result: TallestMountain = {
        name: "",
        height: 0
    };
    tallest.forEach(function(tm: TallestMountain){
        if(tm.height>result.height){
            result = tm;
        }
    });

    return result.name;
}

console.log(findNameOfTallestMountain(mountains));


//PRODUCTS
interface Product{
    name: string;
    price: number;
};

let p1: Product = {
    name: "iPhone 12 Pro Max",
    price: 1000,
}; 

let p2: Product = {
    name: "Samsung Galaxy Note20",
    price: 1100,
};

let product: Product[] = [
    p1,
    p2
];

function calcAverageProductPrice(avgPrice: Product[]): number{    
    let count: number = 0;
    let total: number = 0;
    avgPrice.forEach(function(ap:Product){
        total+= ap.price;
        count++;
    });
    return total/count;


    //const arrAvg = product => product.reduce((a,b)=> a.price+b.price, 0) /product.length;
    //return arrAvg;
}

console.log(calcAverageProductPrice(product));


//INVENTORY
interface InventoryItem{
    product: Product,
    quantity: number
};

let i1: InventoryItem = {
    product: {
        name: "motor",
        price: 10.00,
    },
    quantity: 10
};

let i2: InventoryItem = {
    product: {
        name: "sensor",
        price: 12.50,
    },
    quantity: 4
};

let i3: InventoryItem = {
    product: {
        name: "LED",
        price: 1.00,
    },
    quantity: 20
};

let inventory: InventoryItem[] = [
    i1,
    i2,
    i3
];

function calcInventoryValue(totalPrice: InventoryItem[]): number{

    let total: number = 0;
    // totalPrice.forEach(function(p:InventoryItem){
    //     total+=(p.product.price * p.quantity);
    // });
    // return total;

    //or I can use a loop
    for(let i=0; i<totalPrice.length; i++){
        total += totalPrice[i].product.price * totalPrice[i].quantity;
    }
    return total;
}
console.log(calcInventoryValue(inventory));