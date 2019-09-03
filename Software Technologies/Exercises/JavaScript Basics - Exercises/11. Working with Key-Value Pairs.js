function solve(args) {
    let dict = {};
    let result;

    for (let i = 0; i < args.length; i++) {
        let input = args[i].split(' ');
        let key = input[0];
        let value = input[1];

        if (value === undefined) {
            result = dict[key]
        }

        dict[key] = value;

    }
    if (result === undefined) {
        console.log("None")
    } else {
        console.log(result);
    }
}

solve(['age 15', 'ages 23', 'age']);