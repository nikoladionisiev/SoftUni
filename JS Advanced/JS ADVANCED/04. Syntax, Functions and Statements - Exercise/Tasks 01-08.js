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
function solve(steps, footprintInMeters, speed){
    let length = steps * footprintInMeters;
    let totalRestInMinutes = Math.floor(length / 500);
    let totalTime = length / speed / 1000 * 60;

    let totalTimeInSecond = Math.ceil((totalRestInMinutes + totalTime) * 60);
    
    let result = new Date(null,null,null,null,null, totalTimeInSecond)

    console.log(result.toTimeString().split(' ')[0])
}

//05. Road Radar
function solve(speed, area) {
    let limit = 0;
   switch (area) {
       case 'motorway':
           limit = 130;
           break;
        case 'interstate':
            limit = 90;
            break;
        case 'city':
            limit = 50;
            break;
        case 'residential':
            limit = 20; 
            break;       
   }
  
  
   if (speed > limit) {

    let difference = speed - limit;
    let status;

    if(difference <= 20){
        status = 'speeding';
    }
    else if (difference > 20 && difference <= 40) {
        status = 'excessive speeding';
    } else {
        status = 'reckless driving';
    }
    console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
   }
   else{
        console.log(`Driving ${speed} km/h in a ${limit} zone`);
   }
}

//06. Cooking by Numbers
function solve(params) {
    let n = parseInt(params[0])

    let functions = {
        chop: (x) => x / 2,
        dice: (x) => Math.sqrt(x),
        spice: (x) => x + 1,
        bake: (x) => x * 3,
        fillet: (x) => (0.8 * x).toFixed(1)
    }

    for (let i = 1; i < params.length; i++) {
        n = functions[params[i]](n);
        console.log(n);
    }
}

//07. Validity Checker
function solve(input) {
    let x1 = input[0];
    let y1 = input[1];
    let x2 = input[2];
    let y2 = input[3];

    function distance(x1, y1, x2, y2) {
        let firstDistancePoint = x1 - x2;
        let secondDistancePoint = y1 - y2;
        return Math.sqrt(firstDistancePoint ** 2+ secondDistancePoint ** 2);
    }

    function isValid(x1, y1, x2, y2) {
        if (Number.isInteger(distance(x1, y1, x2, y2))) {
            return `{${x1}, ${y1}} to {${x2}, ${y2}} is valid`;
        }
        return `{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`;
    }

    console.log(isValid(x1, y1, 0, 0));
    console.log(isValid(x2, y2, 0, 0));
    console.log(isValid(x1, y1, x2, y2));
}
