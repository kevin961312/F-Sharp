module SumofOddNumbers

let rowSumOddNumbers n =
    Seq.initInfinite (fun n -> n + 1)
        |> Seq.filter (fun x -> (x % 2) = 1)
        |> Seq.skip ([1..(n - 1)] |> List.sum)
        |> Seq.take n
        |> Seq.sum

rowSumOddNumbers 2

let getMinMax list = List.min list, List.max list