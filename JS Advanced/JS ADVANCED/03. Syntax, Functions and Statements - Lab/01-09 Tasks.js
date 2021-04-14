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
        case '+': result = num1 + num2; break;
        case '-': result = num1 - num2; break;
        case '/': result = num1 / num2; break;
        case '*': result = num1 * num2; break;
        case '%': result = num1 % num2  ;break;
        case '**': result = num1 ** num2;break;
    }
    console.log(result);
}

//06. Sum of Numbers N…M




//07. Day of Week
//08. Square of Stars
//09. Aggregate Elements
