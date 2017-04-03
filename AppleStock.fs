module AppleStock

//Apple Stocks - https://www.interviewcake.com/question/python/stock-price
let stock_prices_yesterday = [|10; 7; 5; 8; 11; 9|]

let get_max_profit (inputArray:int[]) = 
    if inputArray.Length < 2 then failwith "Array size is too small"

    let oper (minPrice, maxProfit) currentPrice =
        let potential = currentPrice - minPrice
        let newMaxProfit = max maxProfit potential
        let newMinPrice = min minPrice currentPrice
        (newMinPrice, newMaxProfit)

    let minPrice = inputArray.[0]
    let maxProfit = inputArray.[1] - inputArray.[0]
    let result = Array.fold oper (minPrice, maxProfit) inputArray

    printfn "%d" (snd result)