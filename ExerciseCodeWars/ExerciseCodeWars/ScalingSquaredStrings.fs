module ScalingSquaredStrings
open System
let scale (s: string) (horizCount: int) (vertCount: int) = 
    let element = s.Split '\n'
                    |> Array.map (fun x -> x.ToCharArray() |> Array.map (fun y-> y.ToString()|> String.replicate horizCount) |> String.Concat)
                    |> Array.map (fun x -> x+" "|>String.replicate vertCount)
                    |> String.Concat 
    element.Trim().Replace(" ","\n")    
scale "abcd\nefgh\nijkl\nmnop"  2 3


open System
open System.Text.RegularExpressions


// Extrae información de una cadena de texto a 
//partir de una expresión regular
let (|DateExprMatch|_|) (pattern : string) (str : string) =
        Regex.Match(str, pattern)
        |> (fun result -> if result.Success then
                            match (List.tail [for group in result.Groups -> group.Value]) with
                            | fst :: snd :: trd :: [] -> Some (fst, snd, trd)
                            | group :: fst :: snd :: trd :: [] -> Some (fst, snd, trd)
                            | _ -> None                      
                          else 
                            None)

(|DateExprMatch|_|) @"^(\w+) (\w+) (\w+)$" "http://www.bob.com http://www.b.com http://www.bob.com http://www.bill.com"
