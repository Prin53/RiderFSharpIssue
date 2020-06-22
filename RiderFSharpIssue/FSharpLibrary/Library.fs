namespace FSharpLibrary

open System

type TextAttribute(text: string) =
    inherit Attribute()
    member __.Text = text

type SayType =
    | [<Text("Hello")>] Hello = 0
    | [<Text("Bye")>] Bye = 1
