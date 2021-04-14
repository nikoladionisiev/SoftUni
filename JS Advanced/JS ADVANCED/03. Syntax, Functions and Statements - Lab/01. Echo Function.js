//01. Echo Function
function prints(str){
    return str.length +'\n' + str;
}

//02. String Length
function sum(x, y, i){
    let sumLength;
    let averageLength; 

    let firstArgLength = x.length;
    let secondArgLength = y.length;
    let thirdArgLength = i.length;

    sumLength = firstArgLength + secondArgLength + thirdArgLength;
    averageLength = Math.floor(sumLength / 3);

    console.log(sumLength);
    console.log(averageLength);
}

//03. Largest Number
function solve(num1, num2, num3){

    var number;
    if(num1 > num2 && num1 > num3){
        number = num1;
    }
    else if(num2 > num1 && num2 > num3)
    {
        number = num2
    }
    else{
        number = num3;
    }
    console.log(`The largest number is ${number}.`);
}

//04. Circle Area
function area(x){

    if(typeof(x) == 'number'){
        let circleArea = Math.PI * Math.pow(x, 2);
        console.log(circleArea.toFixed(2));
    }
    else{
        console.log(`We can not calculate the circle area, because we receive a ${typeof(x)}.`);
    }   
}

//05. Math Operations
function solve(num1, num2, operator){
    let result;

    switch (operator) {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
        case '/':
            result = num1 / num2;
         case '*':
            result = num1 * num2;
        case '%':
            result = num1 % num2;
        case '**':
            result = num1 ** num2;

    }
    console.log(result);
}

//06. Sum of Numbers N…M
function solve(n, m){

    let result = 0;

    let num1 = Number(n);
    let num2 = Number(m);

    for (let index = num1; index <= num2; index++) {
        result += index;
    }

    console.log(result);
}

//07. Day of Week
function solve(x) {

    let message;

   switch (x) {
       case 'Monday': message = 1; break;
       case 'Tuesday': message = 2; break;
       case 'Wednesday': message = 3; break;
       case 'Thursday': message = 4; break;
       case 'Friday': message = 5; break;
       case 'Saturday': message = 6; break;
       case 'Sunday': message = 7; break;
       default:
        message = 'error';
           break;
   }
   console.log(message);
}

//08. Square of Stars
function solve(x)
{
    let n = Number(x);
    for (let i = 0; i < n; i++) {
        console.log("* ".repeat(n));
    }
    
}

//09. Aggregate Elements

