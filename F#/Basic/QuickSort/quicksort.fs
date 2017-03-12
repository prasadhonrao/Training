let rec quicksort = function
    | [] -> []
    | x :: xs ->
        let smaller = List.filter ((>) x) xs
        let larger = List.filter ((<=) x) xs
        quicksort smaller @ [x] @ quicksort larger

let sorted = quicksort [4;5;4;7;9;1;6;1;0;-99;10000;3;2]
for i in sorted do
   printf "%d " i
printfn "done"