type TwoNumbers = int * int // a type with two integer values

let add((first, second):TwoNumbers) =
    first  + second

let result = add (1,2)
printfn "%d" result