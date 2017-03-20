let f arr = arr |> Array.map (fun x -> abs x ) |>

//----------------DON'T MODIFY---------------

let input =[1;-2;-3;4;-5]

let print_out (data:int list) = List.iter (fun x -> printfn "%A" x) data

print_out (f(input))
