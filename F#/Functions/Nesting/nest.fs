// Print a dynamic series 
let PrintNumbersWithSquares min max =
    let square n = // local function!
        n * n
    for n in min..max do
        printfn "%d %d" n (square n)
    printfn " "
