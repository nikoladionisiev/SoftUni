function solve(arr) {
    let numbers = arr.map(Number);
    
    console.log(numbers.reduce((a, b) => a * b))
}
solve(['3','2'])