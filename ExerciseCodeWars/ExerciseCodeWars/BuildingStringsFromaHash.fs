module BuildingStringsFromaHash

open System
open System.Collections.Generic

let solution (dic:Dictionary<'TKey,'TValue>) = 
    let keys = dic |> Dictionary.KeyCollection |> List.ofSeq
    let values = dic |> Dictionary.ValueCollection |> List.ofSeq
    [for i in 0..keys.Length-1 -> keys.[i].ToString()+" = "+values.[i].ToString()]
    |> String.concat ","

let dataPt2 = [
        '^',1
        '&',2
        '$',90
        '1',1300
        '*',8
                  ] |> dict

let dictTwo = new Dictionary<char,int>(dataPt2)
solution dictTwo    