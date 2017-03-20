type System.String with
    member x.IsCapitalized
        with get() =
            System.Char.IsUpper(x.[0])
    member x.CapitalizeFirstLetter
        with get() = 
            System.Char.ToUpper(x.[0]).ToString()

let name = "F# is really cool language"
printfn "Name capitalized? %b" name.IsCapitalized
printfn "%b" "i am not captialized".IsCapitalized

let str = "this is cool!".CapitalizeFirstLetter
printfn "%s" str  