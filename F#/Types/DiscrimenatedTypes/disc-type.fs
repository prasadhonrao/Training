type Shape =
    | Square of float
    | Rectangle of float * float
    | Circle of float

let s = Square 3.4
let r = Rectangle (2.2, 1.9)
let c = Circle 1.0

let Area (shape: Shape) =
    match shape with
    | Square x -> x * x
    | Rectangle (h, w) -> h * w
    | Circle r -> System.Math.PI * r  * r

printfn "Square area %f" (Area s)

let drawings = [|s; r; c|]

let total = drawings |> Array.sumBy Area

printfn "Area sum total %f" total