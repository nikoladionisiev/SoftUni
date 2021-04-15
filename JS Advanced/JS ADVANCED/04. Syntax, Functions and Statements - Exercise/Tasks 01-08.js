//01. Fruit
function solve(fruit, weight, price){

    weight = weight / 1000;
    let money = (price * weight).toFixed(2);
    console.log(`I need $${money} to buy ${weight.toFixed(2)} kilograms ${fruit}.`);
}
