type MutablePerson(firstName: string, lastName: string) =
    let mutable _firstName = firstName
    let mutable _lastName = lastName
    member this.FirstName
        with get () = _firstName
        and set value = _firstName <- value
    member this.LastName
        with get () = _lastName
        and set value = _lastName <- value

let p3 = MutablePerson(firstName = "Prasad", lastName = "Honrao")
p3.FirstName <- "Rajveer"

// Shorter version to declare mutable type
type MutablePerson2(firstName: string, lastName: string) =
    member val FirstName = firstName with get, set
    member val LastName = lastName with get, set