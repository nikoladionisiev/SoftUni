//01. Print an Array with a Given Delimiter
function solve(input, delimiter) { 
    console.log(input.join(delimiter));
}

//02. Print every N-th Element from an Array
function solve(array, number) {
    for (let i = 0; i < array.length; i += number) {
        console.log(array[i]);
    }
}

//03. Add and Remove Elements
function solve(array) {

    let numbers = [];
    let counter = 1;

    for (let i = 0; i < array.length; i++) {
        if (array[i] == 'add') {
            numbers[i] = counter;
            counter++;
        }
        else{
            numbers.pop();
            counter++;
        }       
    }

    if (numbers.length === 0) {
        console.log('Empty');
    }
    else{

        numbers.forEach(element => {
            console.log(element);
        });
    }
}

//04. Rotate Array
function solve(array, number) {
    
    for (let i = 0; i < number; i++) {
        let last = array.pop();
        array.unshift(last);
    }

    console.log(array.join(' '));
}

//05. Extract Increasing Subsequence from Array
function solve(array) {
    let numbers = [];
    let firstElement = array[0];
    numbers.push(firstElement);

    for (let i = 1; i < array.length; i++) {
        if(array[i] > array[i - 1] && array[i] > firstElement)
        {
            numbers.push(array[i]);
        }        
    }
   
    numbers.forEach(element => {
        console.log(element)
    });
}

//06. List Of Names
function solve(array) { 
    let counter = 1;
    array.sort();

    array.forEach(element => {
        console.log(`${counter}.${element}`)
        counter++;
    });
}

//07. Sorting Numbers
function solve(array) {

    let numbers = [];
    array.sort(function(a, b) { return a - b;});

    let length = array.length;
    let counter = 0;

    for (let i = 0; i < length; i++) {
        if(i % 2 == 0)
        {
            numbers.push(array[counter]);
            counter++;
        }
        else{
            numbers.push(array.pop());
        }
    }


    numbers.forEach(element => {
        console.log(element);
   });
}

function solve(array) {
    array.sort(twoCriteriaSort);

    function twoCriteriaSort(cur, next) {
        if (cur.length === next.length) {
          return cur.localeCompare(next);
        }
        return cur.length - next.length;
      }

    array.forEach(element => {
        console.log(element);
    });
}


solve(['test', 
'Deny', 
'omen', 
'Default']);
