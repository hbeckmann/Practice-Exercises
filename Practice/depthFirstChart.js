function parseGrid(str) {
    var rows = str.split(/\n/);
    var firstRow = rows[0];
    var grid = rows.slice(1).map(parseRow);
    return grid;
}

function parseRow(row) {
    return row.split(/\s+/).map(function(cell) {
        return parseInt(cell,10);
    });
}

/**
 * Take a rectangular grid of numbers and find the length
 * of the longest sub-sequence.
 * Return the length as an integer.
 */
function longestSequence(grid) {
    // TODO: Complete this function
    var longestLength = 0;
    var currentNumber;
    var currentLength;
    var checkedNumbers = [];
    for(var x in grid) {
       var row = grid[x];
       for(var y in row){
           startSearch(row[y], x, y, grid);
       }
    }

    function startSearch(startingPoint, rowIndex, colIndex, grid) {
        currentNumber = startingPoint;
        currentLength = 1;
        checkedNumbers = [];
        checkedNumbers.push(currentNumber);
        checkSurroundingNumbers(colIndex, rowIndex, grid)
    }

    function checkSurroundingNumbers(colIndex, rowIndex, grid) {

        var right = grid[rowIndex][parseInt(colIndex) + 1];
        var left = grid[rowIndex][parseInt(colIndex) -1];

        if(grid[parseInt(rowIndex) + 1]) {
           var down = grid[parseInt(rowIndex) + 1][colIndex];
           var downRight = grid[parseInt(rowIndex) + 1][parseInt(colIndex) + 1];
           var downLeft = grid[parseInt(rowIndex) + 1][parseInt(colIndex) - 1];

        }
        if(grid[parseInt(rowIndex) - 1]) {
           var up = grid[parseInt(rowIndex) - 1][colIndex];
           var upRight = grid[parseInt(rowIndex) - 1][parseInt(colIndex) + 1];
           var upLeft = grid[parseInt(rowIndex) - 1][parseInt(colIndex) - 1]
        }




        function checkDirection(direction, nextCIndex, nextRIndex){
            if(direction || direction == 0){
                if(!checkedNumbers.includes(direction)){
                    if(direction > currentNumber + 3 || direction < currentNumber - 3){
                        currentLength++
                        if(currentLength > longestLength) {
                            longestLength = currentLength;
                        }
                        checkedNumbers.push(direction);
                        currentNumber = direction;
                        checkSurroundingNumbers(nextCIndex, nextRIndex, grid);
                        checkedNumbers.pop();
                        currentLength--
                    }
                }
            }
        }

        checkDirection(right, parseInt(colIndex) + 1, rowIndex);
        checkDirection(left, parseInt(colIndex) - 1, rowIndex);
        checkDirection(up, colIndex, parseInt(rowIndex) - 1);
        checkDirection(upRight, parseInt(colIndex) + 1, parseInt(rowIndex) - 1);
        checkDirection(upLeft, parseInt(colIndex) - 1, parseInt(rowIndex) - 1);
        checkDirection(down, colIndex, parseInt(rowIndex) + 1);
        checkDirection(downRight, parseInt(colIndex) + 1, parseInt(rowIndex) + 1);
        checkDirection(downLeft, parseInt(colIndex) - 1, parseInt(rowIndex) + 1);

    }

    return longestLength;
}

function main() {
    var data = '';
    process.stdin.resume();
    process.stdin.setEncoding('utf-8');
    process.stdin.on('data', function(chunk) {
        data += chunk;
    });

    process.stdin.on('end', function() {
        var grid = parseGrid(data);
        var length = longestSequence(grid);
        console.log(length);
    });
}

main();
