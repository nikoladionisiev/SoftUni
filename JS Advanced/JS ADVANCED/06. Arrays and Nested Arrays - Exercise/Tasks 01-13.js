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

solve(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15);