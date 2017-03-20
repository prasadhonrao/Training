// Print a dynamic series
let PrintNumbersWithSquares min max =

    let square n = n * n // local function!

    for n in min..max do
        printfn "%d %d" n (square n)
    printfn " "

PrintNumbersWithSquares  1 10