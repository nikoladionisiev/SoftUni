function solve(numbers) {
    let result;
    for (let i = 0; i <= numbers.length; i++) {
       
        if (numbers[i]/10 % 2 != 0) {
            numbers.splice(i, 1);
        }
        else{
            result += numbers[i]
        }
    }
    console.log(numbers);
    console.log(result);

}

solve(['20', '30', '40', '50', '60']);