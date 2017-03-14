module HackerRank

open System

let reverseList list = List.fold (fun acc elem -> elem::acc) [] list

let listToReverse =
    [
     let mutable key = Console.ReadLine()
     while not (key = null) do
        yield key
        key <- Console.ReadLine()
    ]

let result = reverseList listToReverse

for n in result do
    printfn "%s " n