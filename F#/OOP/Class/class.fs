//namespace OOP

type Person(firstName: string, lastName: string) =
    // default constructor
    new() = Person("", "")
    member this.FirstName = firstName
    member __.LastName = lastName // this can be replaced using __
    member this.GetFullName = firstName + " " + lastName

let p1 = Person("Prasad", "Honrao")
printfn "%A" p1

let p2 = Person(firstName = "Prasad", lastName = "Honrao")
printfn "%A" p2
printfn "Full name : %s" p2.GetFullName

let p3 = Person()
printfn "Full name : %s" p3.GetFullName