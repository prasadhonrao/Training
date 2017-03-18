// Arrays use square brackets with bar

let numbers = [| 10; 20; 30; 40; 50 |]

printfn "Array elements are"
numbers |> Seq.iter (printf "%d ")

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

// Declare array using expression
let array3 = [| for i in 1 .. 10 -> i * i |]
printf "%A" array3

// Accessing array element
let first1000 = [|1..1000|]
printf  "%d" first1000.[0] // first element
printf  "%A" first1000.[0..1] //first 2 elements