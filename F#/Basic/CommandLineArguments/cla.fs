open System

// [<EntryPoint>]
// let main argv =
//     printfn "%A" argv
//     0 // return an integer exit code

[<EntryPoint>]
let main argv =
    let a = Console.ReadLine() |> int
    let b = Console.ReadLine() |> int
    printfn "%d" ( a + b )
    Console.ReadKey() |> ignore
    0 // return an integer exit code
