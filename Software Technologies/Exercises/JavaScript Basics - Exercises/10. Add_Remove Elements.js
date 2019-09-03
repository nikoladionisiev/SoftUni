function solve(args) {

    let arr = [];

    for (let i = 0; i < args.length; i++) {
        let currentLine = args[i].split(' ');
        let command = currentLine[0].trim();
        let number = Number(currentLine[1].trim());

        if (command == "add") {
            arr.push(number);
        }
        else if (command == "remove") {
            arr.splice(number, 1)
        }
    }

    console.log(arr.join('\n'));
}

solve(['add', '1'])