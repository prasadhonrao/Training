module HackerRank

open System

let f arr = arr |> Array.filter(fun x -> x % 2 <> 0) |> Array.sum

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr |> List.toArray

let main =
    let arr = read_and_parse()
    printf "%A" <| f arr