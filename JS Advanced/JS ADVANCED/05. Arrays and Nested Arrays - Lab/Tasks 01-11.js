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
function solve(array) {
    let biggestItem = Number.MIN_SAFE_INTEGER;

    for (let i = 0; i < array.length; i++) {
        for (let j = 0; j < array[i].length; j++) {
           if (array[i][j] >= biggestItem){
               biggestItem = array[i][j]; 
           }
        }        
    }
  
    console.log(biggestItem);
}

//10. Diagonal Sums
function solve(matrix) {

    let firstDiagonal = 0;

    for (let row = 0; row < matrix.length; row++) {
        let number = Number(matrix[row][row]);
        firstDiagonal += number;
    }
    
    let secondDiagonal = 0;
    let row = 0;
    for (let col = matrix.length - 1; col >= 0; col--) {
        let number = Number(matrix[row][col]);
        secondDiagonal += number;
        row++;
    }
    console.log(`${firstDiagonal} ${secondDiagonal}`);
}

//11. Equal Neighbors
function solve(args) {

    let counter = 0;
  
    for (let index = 0; index < args.length-1; index++) {  
  
      for (let j = 1; j < args[index].length; j++) {   
  
       if(args[index][j] == args[index+1][j]){
  
          counter++;
  
        }
  
        if(args[index][j] == args[index][j - 1]){
  
          counter++;
  
        }
  
      }
  
    }
  
    for (let index = 0; index < args[args.length-1].length; index++) {
  
      if(args[args.length-1][index] == args[args.length-1][index + 1]){
  
        counter++;
  
      }
  
    }
  
    for (let index = 0; index < args.length-1; index++) {
  
      if(args[index][0] == args[index+1][0]){
  
        counter++;
  
      }
  
    }
  
    console.log(counter)
  
    }

solve([['2', '3', '4', '7', '0'],
['4', '0', '5', '3', '4'],
['2', '3', '5', '4', '2'],
['9', '8', '7', '5', '4']]);