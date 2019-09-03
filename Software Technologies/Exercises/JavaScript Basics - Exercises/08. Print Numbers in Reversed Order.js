function solve(args) {
    let reversed = args.map(Number).reverse();
    for (let i = 0; i < reversed.length; i++) {
        console.log(reversed[i]);
        
    }
}

solve(['10', '15', '20'])