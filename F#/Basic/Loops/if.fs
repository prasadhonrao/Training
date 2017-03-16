let Greeting name =
    if System.String.IsNullOrWhiteSpace(name) then
        "whoever you are"
    else
        name

printfn "Hi, %s" (Greeting "Prasad")
printfn "Hi, %s" (Greeting "")