type System.String with
    member x.IsCapitalized
        with get() =
            System.Char.IsUpper(x.[0])

let name = "F# is really cool language"

printfn "Name capitalized? %b" name.IsCapitalized

printfn "%b" "i am not captialized".IsCapitalized