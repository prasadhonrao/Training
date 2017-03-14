let listSum = [1;2;3;4]
                |> List.filter (fun i -> i % 2 = 0)
                |> List.map((*)2)
                |> List.sum

printfn "%d" listSum