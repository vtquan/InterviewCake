module BiggestProductOf3

// Highest Product of 3 - https://www.interviewcake.com/question/swift/highest-product-of-3
let input = [|-10; -10; 1; 3; 2|]

let FindHighestProduct (inputArray:int[]) =
    //if we use Array.max or Array.min to find highest or lowest then we might end up max or min with themself later in the function
    let lowest = min inputArray.[0] inputArray.[1]
    let highest = max  inputArray.[0] inputArray.[1]
    let highestProductOf2 = inputArray.[0] * inputArray.[1]
    let lowestProductOf2 = inputArray.[0] * inputArray.[1]
    let highestProductOf3 = inputArray.[0] * inputArray.[1] * inputArray.[2]

    let rec operation index maxProductOf2 minProductOf2 maxProductOf3 =
        if inputArray.Length > index then
            let currentValue = inputArray.[index]

            // The largest product of 3 must be either the product of the 2 highest and another number or the 2 lowest and another number
            let maxProduct3 = 
                max maxProductOf3 (maxProductOf2 * currentValue) 
                |> max (minProductOf2 * currentValue)

            // make sure that we have the two highest
            let maxProduct2 = max (highest * currentValue) maxProductOf2

            let minProduct2 = min (lowest * currentValue) minProductOf2
            
            operation (index+1) maxProduct2 minProduct2 maxProduct3
        else
            maxProductOf3

    operation 2 highestProductOf2 lowestProductOf2 highestProductOf3

FindHighestProduct input
    
