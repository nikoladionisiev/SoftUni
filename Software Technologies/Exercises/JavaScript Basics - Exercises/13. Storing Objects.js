function solve(args) {


    let obj = new Object();

    for (let i = 0; i < args.length; i++) {
        let input = args[i].split(" -> ");
        let name = input[0];
        let age = input[1];
        let grade = input[2];

        // console.log(`Name: ${name}`);
        // console.log(`Age: ${age}`);
        // console.log(`Grade: ${grade}`);
         obj = {"Name":  name, "Age": age, "Grade": grade}
         console.log(`Name: ${obj.Name}`);
        console.log(`Age: ${obj.Age}`);
        console.log(`Grade: ${obj.Grade}`);
        
    }
}

solve(["Pesho -> 13 -> 6.00"])