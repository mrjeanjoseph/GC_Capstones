//Adding all itmes in this array.
let items = [];

//Adding to reuse instead of creating multiple methods
function addItems(name, price){
    ;let item = {
        name: name,
        price: price
    }
    items.push(item);
}

// Note A - Another way to add items
function AddObject(item){

    items.push(item);
}

function addChips(){
    let chips = {
        name: "Chips",
        price: 1.99
    };
    items.push(chips);
}

function addSoda(){
    let soda = {
        name: "Chips",
        price: 1.99
    };
    items.push(soda);
}


function addPretzels(){
    let pretzels = {
        name: "Chips",
        price: 1.99
    };
    items.push(pretzels);
}

//Checkout
function checkout(){
    let total = 0;
    
    items.forEach(i => {
        console.log(`${i.name} ${i.price}`);
    total += i.price;
});
console.log(`Total: ${total}`);

}