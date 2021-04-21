module Reduce

let ReduceDemo (arr: array<string>) =
    arr
    |>  Array.reduce (fun acc elem -> sprintf "%s, %s" acc elem)

let ReduceDemoSum (arr: array<string>) =
    arr
    |>  Array.reduce (+)

ReduceDemoSum [|"aaa";"bbb";"ccc"|]