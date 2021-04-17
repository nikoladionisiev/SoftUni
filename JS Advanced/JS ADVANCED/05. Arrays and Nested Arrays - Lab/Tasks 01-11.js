//01. Even Position Elements
function solve(numbers) {
    let items = [];
    for (let i = 0; i < numbers.length; i++) {
        if (i % 2 === 0) {
            items.push(numbers[i]);
        }
    }
    console.log(items.join(' ').trim());
}

//02. Last K Numbers Sequence

function solve(n, k) {
    let array = [];
    array[0] = 1;

for(let i = 1; i < n; i++)
{
    let sum = 0;
    let startIndex = Math.max(0, i - k);

    for (let j = startIndex; j < i; j++)
    {
        sum += array[j];
    }

    array[i] = sum;
}

console.log(array.join(' ').trim());
}

//03. Sum First Last
function solve(arr) {
    let first = arr[0];
    let last = arr[arr.length - 1];

    let sum = +first + +last;

    console.log(sum);
}

//04. Negative / Positive Numbers
function solve(array) {
    let resultArray = [];

    for(let item of array) {
        if (item < 0) {
            resultArray.unshift(item);
        } else {
            resultArray.push(item);
        }
    }
    for (let item of resultArray) {
        console.log(item);
    }
}

//05. Smallest Two Numbers
function solve(array) {
    let sortedArray = array.sort((a,b) => a - b);
    let firstSmallestNumber = sortedArray.shift();
    let secondSmallestNumber = sortedArray.shift();
 
    console.log(`${firstSmallestNumber} ${secondSmallestNumber}`);
}

//06. Bigger Half
function solve(array) {

    let numbers = [];

    array.sort((a, b) => a - b);

    let halfArr = Math.floor( array.length / 2);

    for (let i = halfArr; i < array.length; i++) {
        numbers[i] = array[i];     
    }
   
    console.log(numbers);

}

//07. Piece of Pie
function solve(array, firstFlavor, secondFlavor){
    let result = [];
    for (let i = 0; i < array.length; i++) {
        if(array[i] == firstFlavor)
        {
            for (let j = i; j < array.length; j++) {
                result.push(array[j])
               if (array[j] == secondFlavor) {
                   console.log(result);
                   return;
               }
                
            }
           
        }        
    }
}

//08. Process Odd Positions
function solve(array) {
    let result = [];
    for (let i = 0; i < array.length; i++) {
        if (i % 2 != 0) {
            result.push(array[i] * 2)
        }        
    }

    result.reverse();
    console.log(result);
}

//09. Biggest Element
