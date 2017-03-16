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