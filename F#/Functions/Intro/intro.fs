// Usual way of declaring a function
let GreetUser (userName,  greeting) = printfn "%s %s" userName greeting
GreetUser ("Prasad", "Hello")

// same function rewritten without brackets
let GreetUser2 userName greeting = printfn "%s %s" userName greeting
GreetUser2 "Prasad" "Hello"

let SayHiToYou (you) = printfn "Hi %s" you
SayHiToYou("John")

// fsharp way
let SayHiTo me = printfn "Hi %s" me
SayHiTo "Scott"

let square x = x * x // function declaration
printfn "Square of 4 is %d" (square 4) // function call
printfn "Square of 3 + 1 is %d" (square 3 + 1) // same as square(3) + 1
printfn "Square of 4 is %d" (square (3 + 1))

let linear x = x * 2
printfn "Linear %d" (linear 2) // output functin result

let quadratic y = y ** 2.
printfn "Quadratic %f" (quadratic 10.0)

let Foo name  = printfn "Hellllllloooooooooooo %s" name
Foo "Prasad"

let distance x y = x - y |> abs
let mutable dist = distance 10 20 // declared as mutable to override during second example
printfn "Distance is %d" dist

dist <- distance 10 20 + 1
printfn "Distance 10 20 + 1 is %d" dist

// function nesting
let negate x = x * -1
let squareplus1 x = x * x + 1
let print x = printfn "The number is: %d" x

let squareplus1NegateThenPrint x = print (negate (squareplus1 x))
squareplus1NegateThenPrint 10

// functions can be declared using multiple lines
let add' x y =
    let result =
        x + y
    result

printfn "10 + 10 = %d" (add' 10 10)