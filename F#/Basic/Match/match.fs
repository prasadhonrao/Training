let nameConstants x =
    match x with
    | 2.71 -> "e"
    | 3.14 -> "pi"
    | _ -> "unknown"

printfn "%s" (nameConstants 2.71)

//-------------------------------------------

let describe (x: obj) =
    match x with
    | :? int -> "It's an int"
    | :? float -> "It's a float"
    | _ -> "Not sure"

printfn "%s" (describe 2.71)

//-------------------------------------------

let compare x y =
    match (x, y) with
    | (x, y) when x > y -> printfn "x > y"
    | (x, y) when x < y -> printfn "x < y"
    | _ -> printfn "x = y"

compare 1 2
