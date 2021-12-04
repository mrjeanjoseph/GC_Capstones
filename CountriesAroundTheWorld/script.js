class Country {
    constructor(name, lang, greeting, colors) {
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
    }
}
let usa = new Country("USA", "Murican", "Why Hello there world! Have some McDonalds", ["red", "white", "blue"]);
let haiti = new Country("Haiti", "Haitian Creole", "Sak pase?", ["red", "white", "blue"]);
let brazil = new Country("Brazil", "Portugeuse", "Olá Mundo?", ["green", "red", "blue"]);
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"]);
let algeria = new Country("Algeria", "Arabic and Berber", "Sup", ["blue", "yellow", "red"])


// function DisplayColors(countryNode){
//     // not sure what to do here
//     let ColorNode0 = document.getElementById("Color1");
//     ColorNode0.style.backgroundColor = country.color[0];
//     let ColorNode2 = document.getElementById("Color2");
//     ColorNode2.style.backgroundColor = country.color[1];
//     let ColorNode3 = document.getElementById("Color3");
//     ColorNode3.style.backgroundColor = country.color[2];
// }


function SwitchCountry() {
    let input = document.getElementById("CountryList").value;

    //let countryNode;
    let countryNode = document.getElementById("CountryName");
    let OfficialLanguageNode = document.getElementById("OfficialLanguage");
    let HelloWorldNode = document.getElementById("HelloWorld");
    
    let ColorNode1 = document.getElementById("Color1");
    let ColorNode2 = document.getElementById("Color2");
    let ColorNode3 = document.getElementById("Color3");
    

    if (input === "USA") {
        //set country to usa 
        //countryNode = usa;
        countryNode.innerText = usa.name;
        OfficialLanguageNode.innerText = usa.lang;
        HelloWorldNode.innerText = usa.greeting;
        //DisplayColors(usa);
        ColorNode1.style.backgroundColor = usa.colors[0];
        ColorNode2.style.backgroundColor = usa.colors[1];
        ColorNode3.style.backgroundColor = usa.colors[2];
    }
    else if (input === "Haiti") {
        countryNode.innerText = haiti.name;
        OfficialLanguageNode.innerText = haiti.lang;
        HelloWorldNode.innerText = haiti.greeting;
        //DisplayColors(haiti);
        ColorNode1.style.backgroundColor = haiti.colors[0];
        ColorNode2.style.backgroundColor = haiti.colors[1];
        ColorNode3.style.backgroundColor = haiti.colors[2];
    }
    else if (input === "Brazil") {
        countryNode.innerText = brazil.name;
        OfficialLanguageNode.innerText = brazil.lang;
        HelloWorldNode.innerText = brazil.greeting;
       // DisplayColors(brazil);
        ColorNode1.style.backgroundColor = brazil.colors[0];
        ColorNode2.style.backgroundColor = brazil.colors[1];
        ColorNode3.style.backgroundColor = brazil.colors[2];

    }
    else if (input === "Mexico") {
        countryNode.innerText = mexico.name;
        OfficialLanguageNode.innerText = mexico.lang;
        HelloWorldNode.innerText = mexico.greeting;
        ColorNode1.style.backgroundColor = mexico.colors[0];
        ColorNode2.style.backgroundColor = mexico.colors[1];
        ColorNode3.style.backgroundColor = mexico.colors[2];
    }
    else if (input === "Algeria") {
        countryNode.innerText = algeria.name;
        OfficialLanguageNode.innerText = algeria.lang;
        HelloWorldNode.innerText = algeria.greeting;

        ColorNode1.style.backgroundColor = algeria.colors[0];
        ColorNode2.style.backgroundColor = algeria.colors[1];
        ColorNode3.style.backgroundColor = algeria.colors[2];
    }
}