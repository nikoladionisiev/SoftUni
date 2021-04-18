//01. Print an Array with a Given Delimiter
function solve(input, delimiter) { 
    console.log(input.join(delimiter));
}

//02. Print every N-th Element from an Array
function solve(array, number) {
    for (let i = 0; i < array.length; i += number) {
        console.log(array[i]);
    }
}

//03. Add and Remove Elements
function solve(array) {

    let numbers = [];
    let counter = 1;

    for (let i = 0; i < array.length; i++) {
        if (array[i] == 'add') {
            numbers[i] = counter;
            counter++;
        }
        else{
            numbers.pop();
            counter++;
        }       
    }

    if (numbers.length === 0) {
        console.log('Empty');
    }
    else{

        numbers.forEach(element => {
            console.log(element);
        });
    }
}

//04. Rotate Array
function solve(array, number) {
    
    for (let i = 0; i < number; i++) {
        let last = array.pop();
        array.unshift(last);
    }

    console.log(array.join(' '));
}

//05. Extract Increasing Subsequence from Array
function solve(array) {
    let numbers = [];
    let firstElement = array[0];
    numbers.push(firstElement);

    for (let i = 1; i < array.length; i++) {
        if(array[i] > array[i - 1] && array[i] > firstElement)
        {
            numbers.push(array[i]);
        }        
    }
   
    numbers.forEach(element => {
        console.log(element)
    });
}

//06. List Of Names
function solve(array) { 
    let counter = 1;
    array.sort();

    array.forEach(element => {
        console.log(`${counter}.${element}`)
        counter++;
    });
}

//07. Sorting Numbers
function solve(array) {

    let numbers = [];
    array.sort(function(a, b) { return a - b;});

    let length = array.length;
    let counter = 0;

    for (let i = 0; i < length; i++) {
        if(i % 2 == 0)
        {
            numbers.push(array[counter]);
            counter++;
        }
        else{
            numbers.push(array.pop());
        }
    }


    numbers.forEach(element => {
        console.log(element);
   });
}

//08. Sort an Array by 2 Criteria
function solve(array) {
    array.sort(twoCriteriaSort);

    function twoCriteriaSort(cur, next) {
        if (cur.length === next.length) {
          return cur.localeCompare(next);
        }
        return cur.length - next.length;
      }

    array.forEach(element => {
        console.log(element);
    });
}

//09. Magic Matrices
function solve(array) {

    let isTrue = true;
    let firstSum = array[0].reduce((a, b) => a + b, 0);

    for (let row = 0; row < array.length; row++) {
        let sum =  array[row].reduce((a, b) => a + b, 0)
        
        if (sum === firstSum) {
            isTrue = true;
        }
        else{
            isTrue = false;
            break;
        }
    }

    let sum = 0; 

    for (let i = 0; i < array.length; i++) {

        for (let j = 0; j < array.length; j++) {
            
             sum += array[j][i];
        }

        if(sum === firstSum)
        {
            isTrue = true;
        }
        else{
            isTrue = false;
            break;
        }
        sum = 0;
    }

    console.log(isTrue);
  
}

//10. Tic-Tac-Toe
function solve(input) {
    let board = [
      [false, false, false],
      [false, false, false],
      [false, false, false]
    ];
  
    let index = 0;
    const firstPlayer = "F";
    const secondPlayer = "S";
    const maxCountMoved = 9;
  
    let winPlayer = undefined;
    let currentPlayer = firstPlayer;
    let countMoved = 0;
  
    let printBoard = () => {
      for (let row = 0; row < board.length; row++) {
        const elements = board[row];
        console.log(elements.join("	"));
      }
    };
  
    while (true) {
  
      if (countMoved === maxCountMoved) {
        console.log("The game ended! Nobody wins :(");
        printBoard();
        break;
      }
      const playerCoordinates = input[index].split(" ");
      const row = Number(playerCoordinates[0]);
      const col = Number(playerCoordinates[1]);
  
      if (currentPlayer === firstPlayer && !board[row][col]) {
        board[row][col] = "X";
      } else if (currentPlayer === secondPlayer && !board[row][col]) {
        board[row][col] = "O";
      } else {
        console.log("This place is already taken. Please choose another!");
        index++;
        continue;
      }
  
      if (hasWin()) {
        console.log(`Player ${winPlayer} wins!`);
        printBoard();
        break;
      }
  
      if (currentPlayer === firstPlayer) {
        currentPlayer = secondPlayer;
      } else {
        currentPlayer = firstPlayer;
      }
      index++;
      countMoved++;
    }
  
    function hasWin() {
      if (isWinPlayer("X")) {
         return true;
      }
  
      if (isWinPlayer("O")) {
         return true;
      }
      return false;
    }
    function markHasWinner(count, maxCountForWin, player) {
      if (count === maxCountForWin) {
        winPlayer = player;
        return true;
      }
      return false;
    }
  
    function isWinPlayer(player) {
      const maxCountForWin = 3;
      let count = 0;

      for (let row = 0; row < board.length; row++) {
        const elements = board[row];
        for (let item of elements) {
          if (item !== player) {
            break;
          }
          count++;
        }
  
        if (markHasWinner(count, maxCountForWin, player)) {
          return true;
        }
      }
  
      count = 0; 
      for (let row = 0; row < board.length; row++) {
        const element = board[row][0];
  
        if (element === player) {
          winPlayer = player;
          count++;
        }
      }
  
      if (markHasWinner(count, maxCountForWin, player)) {
        return true;
      }

      count = 0;
  
      for (let row = 0; row < board.length; row++) {
        const element = board[row][row];
  
        if (element === player) {
          winPlayer = player;
          count++;
        }
      }
  
      if (markHasWinner(count, maxCountForWin, player)) {
        return true;
      }
  
      let row = 0;
      for (let i = board.length - 1; i >= 0; i--) {
        const element = board[row][i];
        if (element === player) {
          winPlayer = player;
          count++;
        }
        row++;
      }

      return false;
    }
  }

//11. Diagonal Attack
function solve(input) {
    let matrix = parseMatrixToNumber(input);

    let firstSum = firstDiagonalSum(matrix);
    let secondSum = secondDiagonalSum(matrix);

    if (firstSum === secondSum) {
        changeMatrix(matrix, firstSum);
    }

    printMatrix(matrix);

    function firstDiagonalSum(matrix) {
        let sum = 0;
        for (let row = 0; row < matrix.length; row++) {
            const element = matrix[row][row];
            sum += element;
        }

        return sum;
    }

    function secondDiagonalSum(matrix) {
        let sum = 0;
        let col = 0;
        for (let row = 0; row < matrix.length; row++) {
            let colElement  = matrix[row].slice().reverse()[col];
            sum += colElement;
            col++;
        }
        return sum;
    }

    function changeMatrix(matrix, sum) {
        for (let row = 0; row < matrix.length; row++) {
            for (let col = 0; col < matrix[row].length; col++) {
                let specialCol = matrix[row].length - row - 1;
                if (row !== col && col !== specialCol) {
                    matrix[row][col] = sum;
                }
            }
        }
    }

    function printMatrix(matrix) {
        for (let row = 0; row < matrix.length; row++) {
            const elements = matrix[row];
            console.log(elements.join(' '));
        }
    }

    function parseMatrixToNumber (input) {
        let result = [];

        for (let row = 0; row < input.length; row++) {
            let currentRow = input[row].split(' ').map(x => Number(x));
            result.push(currentRow);
        }

        return result;
    };
}

//12. Orbit
function solve(input) {
    let [rows, cols, y, x] = input;

    function initializeMatrix() {
        let result = [];

        for (let row = 0; row < rows; row++) {
            result[row] = [cols];
            for (let col = 0; col < cols; col++) {
                result[row][col] = 0;
            }
        }
        return result;
    }

    let matrix = initializeMatrix();
    
    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix.length; col++) {
            matrix[row][col] = Math.max(Math.abs(y - row),Math.abs(x - col)) + 1;
        }
    }

    for (let row = 0; row < matrix.length; row++) {
        const elements = matrix[row];
        console.log(elements.join(' '));
    }
}

//13. Spiral Matrix
function solve(rows, cols) {
    let matrix = [];

    for (let row = 0; row < rows; row++) {
      matrix[row] = [cols];
      for (let col = 0; col < cols; col++) {
        matrix[row][col] = 0;
      }
    }
  
    let counter = 1;
  
    let currentRow = 0;
    let currentCol = 0;
    let isFillMatrix = false;
    while (true) {

      while (currentCol < cols) {
        if (matrix[currentRow][currentCol]) {
          isFillMatrix = true;
          break;
        } else {
          matrix[currentRow][currentCol++] = counter++;
          isFillMatrix = false;
        }
      }
  
      currentCol -= 1;
      let row = currentRow + 1;
  

      while (row < rows) {
        if (matrix[row][currentCol]) {
          isFillMatrix = true;
          break;
        } else {
          matrix[row++][currentCol] = counter++;
          isFillMatrix = false;
        }
      }
  
      currentCol -= 1;
      row -= 1;

      while (currentCol >= 0) {
        if (matrix[row][currentCol]) {
          isFillMatrix = true;
          break;
        } else {
          matrix[row][currentCol--] = counter++;
          isFillMatrix = false;
        }
      }
      row -= 1;
      currentCol += 1;
      while (row > currentRow) {
        if (matrix[row][currentCol]) {
          isFillMatrix = true;
          break;
        } else {
          matrix[row--][currentCol] = counter++;
          isFillMatrix = false;
        }
      }
  
      if (isFillMatrix) {
         break;
      }
      currentRow++;
      currentCol += 1;
    }
  
    for (let row = 0; row < matrix.length; row++) {
        const elements = matrix[row];
        console.log(elements.join(' '));
    }
  }