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

solve(200, 'motorway');