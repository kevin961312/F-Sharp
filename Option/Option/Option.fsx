open System

let firstOdd xs = 
    List.tryPick(fun x -> if x % 2 = 1 then Some x else None) xs

firstOdd [-2;2;3;4]