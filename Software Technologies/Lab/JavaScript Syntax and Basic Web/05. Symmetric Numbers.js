function simetricN(strNumber) {

    let n = Number(strNumber);

    for (let index = 1; index <= n; index++) {
        if (index.toString() === index.toString().split("").reverse().join(""))
        {
           console.log(index)
        }
    }

}
simetricN("750");