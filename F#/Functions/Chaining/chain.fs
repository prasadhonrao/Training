let listSum = [1; 2; 3; 4]
                |> List.filter (fun i -> i % 2 = 0)
                |> List.sumBy((*)2)

printfn "%d" listSum