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