module HighestRankNumberArray

let highestRank (array: int[]) =
    array
    |> Array.countBy id
    |> Array.maxBy (fun (x,y) -> (y,x))
    |> fst
highestRank [|12; 10 ;10;10; 8; 12; 7; 6; 4; 12|]  
highestRank [|12; 10; 8; 8; 3; 3; 3; 3; 2; 4; 10; 12; 10|]