module HackerRank

open System

let rec fib n =
    match n with
    | x when x = 1 -> 0
    | x when x = 2 -> 1
    | _ -> fib (n - 2) + fib (n - 1)

printfn "%d" (fib (Console.ReadLine() |> int) |>int)