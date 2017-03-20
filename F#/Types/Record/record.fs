type Person = {
    FirstName: string
    LastName: string
}

let p = {FirstName = "Prasad"; LastName = "Honrao"}
printfn "%A" p

let p2 = {p with FirstName = "Prajakta"}
printfn "%A" p2