module HackerRank

open System

let n = Console.ReadLine() |> int
let list =
    [
     let mutable key = Console.ReadLine()
     while not (key = null) do
        yield key
        key <- Console.ReadLine()
    ]

list
|> List.iter (fun i -> ( for j = 1 to n do printfn "%s" i))