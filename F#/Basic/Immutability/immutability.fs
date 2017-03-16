let numbers = [3; 2; 1]
let moreNumbers = 4 :: numbers // prepend 4 with numbers

printfn "numbers..."

for i in numbers do
   printfn "%d" i

printfn "more numbers..."

for i in moreNumbers do
   printfn "%d" i