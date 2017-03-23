open System.Numerics

// int
let myAge, yourAge = 10, 20
printfn "My age is %d, and your age is %d" myAge yourAge
(* Be default variables are immutable so you can not override its values unless your declared them mutable explicitly *)
let mutable mutableAge = 30
printfn "Mutable Age %d" mutableAge
mutableAge <- 40
printfn "Mutable Age %d" mutableAge

// big integer
let big = 12345678901234567890I
printfn "Big integer value is %A" big

// float
let pi = 3.14
printfn "Pi value is %f" pi

let randomFloat = 12.
printfn "Random float %f" randomFloat

// byte
open System.Text
let byteValue = [| 104uy; 101uy; 108uy; 108uy; 111uy |]
printfn "%s" (Encoding.ASCII.GetString(byteValue))

// decimal
let decimalValue = 1234.5678M
printfn "Decimal value %f" decimalValue

// char
let c = 'A'
printfn "Character value %c" c

// bool
let boolValue = true
printfn "Bool value %b" boolValue

// string
let hello = "Hello" + " World"
printfn "%s" hello

let verbatimXml = @"<book title=""Paradise Lost"">"
printfn "%s" verbatimXml

let tripleXml = """<book title="Paradise Lost">"""
printfn "%s" tripleXml

let poem =
    "The lesser world was daubed\n\
     By a colorist of modest skill\n\
     A master limned you in the finest inks\n\
     And with a fresh-cut quill."
printfn "%s" poem

type TwoNumbers = int * int // a type with two integer values

let add((first, second):TwoNumbers) =
    first  + second

let result = add (1,2)
printfn "%d" result