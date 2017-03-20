module fsharp.basic

// square function accepting an int and returning an int
let squareInt x = x * x;
let squaredIntList = List.map squareInt [1; 2;3]

for i in squaredIntList do
   printfn "%d" i

// square function accepting a float and returning a float
let squareFloat (x:float) : float = x * x
let sqauredFloatList = List.map squareFloat [1.2; 2.5; 3.9]
for j in sqauredFloatList do
   printfn "%f" j

// doubling list values using map function
let doubles = List.map((*) 2) [1; 2; 3; 4]
for k in doubles do
    printfn "%d" k

// add squares
let addsquares a b = (a*a) + (b*b)
let result = addsquares 5 5
printfn "%d" result