type Role =
    | Developer = 0
    | Manager = 1
    | Other = 2

type Person(firstName: string, lastName: string, experience: int) =
    // default constructor
    let personRole =
        match experience with
        | x when x >= 0 && x <=5 -> Role.Other
        | x when x > 5 && x <=10 -> Role.Developer
        | x when x > 10 -> Role.Manager
        | _ -> Role.Other

    new() = Person("", "", 0)
    member this.FirstName = firstName
    member __.LastName = lastName // this can be replaced using __
    member this.GetFullInfo = firstName + " " + lastName + ", Role : " +  personRole.ToString()


let p = Person("Prasad", "Honrao", 5)
printfn "Full name : %s" p.GetFullInfo