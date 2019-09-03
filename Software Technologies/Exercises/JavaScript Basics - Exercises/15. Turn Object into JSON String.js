function solve(args) {
    let obj = {};

    for (let i = 0; i < args.length; i++) {

        let input = args[i].split(" -> ");
        let key = input[0];
        let value = input[1];

        if (key === "age" || key === "grade") {
            value = Number(value);
        }
        obj[key] = value;
    }

    let json = JSON.stringify(obj);
    console.log(json);
}

solve(["name -> Angel"])