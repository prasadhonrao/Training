type Company = {
    CompanyName : string
    Website : string option
}

let cognizant = { CompanyName = "Cognizant" ; Website = Some "http://cognizant.com" }
let xyz = { CompanyName = "XYZ" ; Website = None }

// Print company details and website address if exists
let PrintCompany (company: Company) =
    let websiteurl =
        match company.Website with
        | Some c -> sprintf "[%s]" c
        | None -> ""

    printfn "%s %s" company.CompanyName websiteurl

PrintCompany cognizant
PrintCompany xyz