function sumIntegers(arr){
   let numbers = arr[0].split(' ');

   let firstNum=Number(numbers[0]);
   let secondNum=Number(numbers[1]);
   let thirdNum=Number(numbers[2]);

   console.log(check(firstNum,secondNum,thirdNum)||
   check(secondNum,thirdNum,firstNum) ||
   check(firstNum,thirdNum,secondNum) ||
   'No');


function check(firstNum,secondNum,thirdNum) {

   if (firstNum + secondNum != thirdNum){

      return false;
   }

   if (firstNum > secondNum){

      [firstNum, secondNum] = [secondNum, firstNum]; // Swap num1 and num2
   }
    return `${firstNum} + ${secondNum} = ${thirdNum}`;
   
   }
}

sumIntegers(["8 15 7"])