module Meeting
open System

let meeting(s: string)=
    s.ToUpper().Split(';')
    |> Array.map (fun element -> element.Split(':') |> Array.rev |> String.concat ", " )
    |> Array.map (fun element -> "("+element+")")
    |> Array.sort
    |> String.Concat

meeting "Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";

meeting "Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn"

let add n = (+) n 

add 