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

let intList = list |> List.map System.Int32.Parse
let result = List.filter (fun x -> x < n = true) intList

for n in result do
    printfn "%d " n