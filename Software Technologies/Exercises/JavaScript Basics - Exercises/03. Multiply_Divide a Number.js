function solve(arr) {
    let numbers = arr.map(Number);

    let sum = 0;

    if (numbers[0] <= numbers[1] ) {
        sum = numbers[0] * numbers[1];
    }
    else{
        sum = numbers[0] / numbers[1];
    }
    console.log(sum)
}

solve(['4','2'])