// Arrays use square brackets with bar

let numbers = [| 10; 20; 30; 40; 50 |]

// Iterating using for..in
printfn "Print array element using for..in loop"

for number in numbers do
    printf "%d " number

printfn "Print array element using Sequence"
numbers |> Seq.iter (printf "%d ")

printfn "Print array element using Array iter method"
Array.iter(fun n -> printf "%d " n) numbers


printfn "First element in the array %d" numbers.[0]

// Another way to declare an array if you want to emit the semicolon
let fruits =
    [|
        "Banana"
        "Apple"
        "Orange"
        "Mango"
        "Pinapple"
    |]
printfn "Printing fruits..."
fruits |> Seq.iter (printf "%s ")
printfn ""

// Declare array using range
let first100 = [|1..100|]
printfn "%A" first100

// Declare array using range with step
let gapof5 = [|0..5..100|]

// Declare array using lambda expression
let array3 = [| for i in 1 .. 10 -> i * i |]
printf "%A" array3

// Declare array using expression
let array4 = [| for i in 1 .. 10 do yield i * i |]
printf "%A" array4

// Accessing array element
let first1000 = [|1..1000|]
printf "%d" first1000.[0] // first element
printf "%A" first1000.[0..4] //first 5 elements

// Array function - filter
let squares = [|for i in 0..99 -> i * i|]

let IsEven n = n % 2 = 0

let evenSquares = Array.filter (fun x -> IsEven x) squares

printfn "%A" evenSquares

// sort
let fruits2 =
    [|
        "Banana"
        "Apple"
        "Orange"
        "Mango"
        "Pinapple"
    |]
let sortedFruits = Array.sort fruits2