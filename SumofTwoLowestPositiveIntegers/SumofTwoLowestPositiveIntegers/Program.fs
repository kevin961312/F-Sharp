let sumTwoSmallestNumbers numbers = 
    numbers   
    |> Array.sort
    |> Array.take 2
    |> Array.sum

sumTwoSmallestNumbers [|19; 5; 40; 2; 77|]