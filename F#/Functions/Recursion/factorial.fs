(* Length *)

let rec length = function
    | [] -> 0
    | x::xs -> 1 + length xs

printfn "List length is %d" (length [10;20;30;40;50;-1;-2])



(* Factorial *)

let rec factorial n =
    if n < 2 then
        1
    else
        n * factorial (n-1)
printfn "Factorial of 5 is %d" (factorial (5))