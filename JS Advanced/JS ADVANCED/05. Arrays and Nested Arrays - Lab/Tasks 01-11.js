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

