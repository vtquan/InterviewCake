module ProductOfOtherNumber

//Product of All Other Numbers - https://www.interviewcake.com/question/python/product-of-other-numbers
let input = [|2;4;10|]

let getProduct (inputArray:int[]) =
    if inputArray.Length < 2 then failwith "Array size is too small"

    let operation acc value =
        (acc, acc * value)

    let operation2 value acc =
        (acc, acc * value)
        
    let productBefore = Array.mapFold operation 1 inputArray
    let productAfter = Array.mapFoldBack operation2 inputArray 1 
    printfn "%A" <| fst productBefore
    printfn "%A" <| fst productAfter
    let result = Array.map2 (fun int1 int2 -> int1 * int2) (fst productBefore) (fst productAfter)
    printfn "%A" result


getProduct input