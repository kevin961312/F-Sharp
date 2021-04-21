module DictionaryDemo

open System.Collections.Generic

type LineRec = {Number : int; Key:string ; Line:string}

let DedupeKeepLast (lines : seq<string> ) = 
    let lineDict = new Dictionary<string, int> ()

    let records = 
        lines
        |> Seq.mapi(fun i line ->
           {Number = i; Key = line.Split([|','|]).[0] ; Line = line})

    records
    |> Seq.iter (fun record ->
           lineDict.[record.Key]<- record.Number)

    records 
    |> Seq.choose (fun record ->
       if record.Number = lineDict.[record.Key] then Some(record.Line)
       else None)
