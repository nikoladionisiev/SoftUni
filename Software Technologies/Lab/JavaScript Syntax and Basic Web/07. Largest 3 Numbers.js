function numbers(arr) {
    let numbers = arr.map(Number).sort((a, b) => b - a);

    let count = Math.min(3, numbers.length)

    for (let i = 0; i < count; i++) {
        console.log(numbers[i])
    }
}

numbers(['10', '30', '15', '20', '50', '5'])