//Find the odd int
open FSharp.Linq

let inline findOdd numbers =
    numbers
    |> Seq.countBy id
    |> Seq.filter (fun (x,y) -> y % 2 =1)
    |> Seq.map fst
    |> Seq.item 0


findOdd  [20; 1; -1; 2; -2; 3; 3; 5; 5; 1; 2; 4; 20; 4; -1; -2; 5]

//Calculate average
let inline avg list = list |> List.average


//Sum of all the multiples of 3 or 5
let findSum n = 
    [1 .. n]
    |> List.where(fun x -> x % 3 =0 || x % 5 =0)
    |> List.sum

findSum 5

//Form The Minimum
open System

let FormMin (arr : List<int>) = 
    arr 
    |> List.distinct
    |> List.sort
    |> String.Concat
    |> int

FormMin [1; 9; 3; 1; 7; 4; 6; 6; 7]



let findUniq list =
  list
  |> Seq.countBy id
  |> Seq.filter(fun (x,y)-> y =1)
  |> Seq.map fst
  |> Seq.item 0