module Types

open System

let private strCaseEq s1 s2 =
    String.Equals(s1, s2, StringComparison.CurrentCultureIgnoreCase)

type Page =
    | Home

    static member All = [ "Home", Home ]

    static member Find(name: string) =
        Page.All
        |> List.tryFind (fun (pname, _) -> strCaseEq pname name)
        |> Option.map snd

type AuthToken = string // Or, use <'AuthToken> for LoggedInUser etc

type LoggedInUser = { Name: string; AuthToken: AuthToken }

type Model = { Page: Page }


let getPage m = m.Page
