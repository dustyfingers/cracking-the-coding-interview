// 1.8 write an algorithm such that if an element in an M x N matrix is zero, its entire row and columns are set to zero


/* zeroMatrix(givenMatrix)                                                                                                      */
/* params:                                                                                                                      */
/* givenMatrix - a 2d array of integers. assume every element is the same length                                                */
/* throws:                                                                                                                      */
/* MatrixLengthError - one of the items in the array is not the correct length                                                  */
/* TypeError - js TypeError("Matrix must contain only numbers, and will only perform operations on integer values")             */
/* returns:                                                                                                                     */
/* the altered matrix                                                                                                           */ 
const zeroMatrix  = givenMatrix => {

    const initialInnerLen = givenMatrix[0].length

    let retMatrix = []

    for (let i = 0; i < givenMatrix.length; i++) 
    {         
        const currentRow = givenMatrix[i]
        retMatrix[i] = [...currentRow] 
    }

    // for each item in the outer array
    for (let i = 0; i < givenMatrix.length; i++) 
    {

        const currentRow = givenMatrix[i]

        // check for matrix validity
        if (currentRow.length !== initialInnerLen) throw "MatrixLengthError - One of the items in the array is not the correct length."
        
        for (let j = 0; j < currentRow.length;j++) 
        {

            // handle type errors
            if (typeof currentRow[j] !== 'number') throw new TypeError("Matrix must contain only numbers, and will only perform operations on integer values")
            
            // if this item is zero, set any item with the same x val or y val as this one to 0

            if (currentRow[j] !== 0) continue
            else
            {
                
                // handle same y values
                for (let k = 0; k < givenMatrix.length; k++) { retMatrix[k][j] = 0 }

                // handle same x values
                retMatrix[i] = new Array(currentRow.length).fill(0)

            }

    
        }

    }
    
    return retMatrix

}

// should return a modified matrix - works
console.log(zeroMatrix([
    [1, 2, 7, 5, 4],
    [3, 4, 4, 3, 1],
    [5, 6, 0, 6, 2]
]))

// should return a modified matrix - works
console.log(zeroMatrix([
    [0, 2, 7, 5, 4],
    [3, 4, 4, 3, 1],
    [5, 6, 9, 6, 2]
]))

// should return a modified matrix - works
console.log(zeroMatrix([
    [0, 2, 7, 5, 4],
    [3, 4, 4, 3, 1],
    [5, 6, 0, 6, 2]
]))

// ! should throw TypeError
// console.log(zeroMatrix([
//     [1, 2, 7, 5, 4],
//     [3, 4, 4, 3, 'ç'],
//     [5, 6, 0, 6, 2]
// ]))

// ! should throw MatrixLengthError
// console.log(zeroMatrix([
//     [1, 2, 7, 5],
//     [3, 4, 4, 3, 1],
//     [5, 6, 0, 6, 2]
// ]))