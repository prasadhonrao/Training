module HackerRank

open System

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr |> List.toArray

let main =
    let arr = read_and_parse()
    let temp_array = Array.rev arr // Original input array has to be reversed!!
    for i in 1 .. 2 .. temp_array.Length - 1 do
    printfn "%d" temp_array.[i]