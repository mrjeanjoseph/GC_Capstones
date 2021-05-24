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


//