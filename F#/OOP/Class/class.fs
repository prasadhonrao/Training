//namespace OOP

type Person(firstName: string, lastName: string) =
    member this.FirstName = firstName
    member __.LastName = lastName // this can be replaced using __

let p1 = Person("Prasad", "Honrao")
printfn "%A" p1

let p2 = Person(firstName = "Prasad", lastName = "Honrao")
printfn "%A" p2


