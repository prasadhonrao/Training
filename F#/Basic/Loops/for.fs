// Print a fixed series
let numbers = [1; 2; 3; 4; 5]
for n in numbers do
    printf "%d " n
printfn " "

// Print a dynamic series
let PrintNumbers min max =
    for n in min..max do
        printf "%d " n
    printfn " "

PrintNumbers 1 10