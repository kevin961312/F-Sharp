module Groupby

open System
open System.IO

let LengthClass length =
    if length < 1024L then "Small"
    else if  length < 1024L * 1024L then "Medium"
    else "Large"

let FileSizeGroup  dirName =
    dirName 
    |> Directory.EnumerateFiles
    |> Seq.map (fun name ->
          let info = new FileInfo(name)
          (name , info.Length))
    |> Seq.groupBy (fun (name,length) -> LengthClass length)

FileSizeGroup @"C:\Users\kevin.pineda\Desktop"