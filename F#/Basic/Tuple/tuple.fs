// declaration
let position = 1.22, 3.4
printfn "%A" position

// use tuple in a function
let randomPosition() =
    let r = new System.Random()
    r.NextDouble(), r.NextDouble()

for i in [-100..10..100] do
    let random1, random2 = randomPosition()
    printfn "%d %f %f" i random1 random2
