module GetSum

let getSum a b =
    if a <= b then {a .. b} |> Seq.reduce (+) else {b .. a} |> Seq.reduce (+)

getSum  5 -1