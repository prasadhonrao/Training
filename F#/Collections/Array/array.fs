// Arrays use square brackets with bar

let numbers = [| 10; 20; 30; 40; 50 |]

printfn "Array elements are"
numbers |> Seq.iter (printf "%d ")

printfn "First element in the array %d" numbers.[0]