module OOP

open System

type Person(firstName: string, lastName: string) =
    let validateString str = // local function to validate inputs
        if String.IsNullOrWhiteSpace str then
            raise (ArgumentException())
    do
        validateString firstName
        validateString lastName

    member val FirstName = firstName with get, set
    member val LastName = lastName with get, set