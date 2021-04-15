//01. Fruit
function solve(fruit, weight, price){

    weight = weight / 1000;
    let money = (price * weight).toFixed(2);
    console.log(`I need $${money} to buy ${weight.toFixed(2)} kilograms ${fruit}.`);
}

//02. Greatest Common Divisor – GCD
function solve(num1, num2){
    while(num2) {
        var t = num2;
        num2 = num1 % num2;
        num1 = t;
      }
      console.log(t)
}

//03. Same Numbers
function solve(number){
   let listNumbers = number.toString().split('');
   let isTrue = true;
   let sum = 0;

   for (let i = 0; i < listNumbers.length; i++) {
       if (isTrue) {
        isTrue = listNumbers[i] === listNumbers[0];
       }

       sum += +listNumbers[i]
   }

    console.log(isTrue);
    console.log(sum);
}

//04. Time to Walk
