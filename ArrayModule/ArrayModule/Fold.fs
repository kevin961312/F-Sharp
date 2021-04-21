module Fold

open System

let PrintRow (separator : string) (arr : array<string>) = 
    arr
    |> Array.fold (fun acc elem -> sprintf "%s%s%s" acc elem separator) separator


PrintRow "casa" [|"piso";"cocina";"drogas"|]
