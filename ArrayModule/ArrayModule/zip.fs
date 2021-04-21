module ZipFunction

let Arraymutiply (arra1 : array<float>) (arra2 : array<float>) : array<float> =
    Array.zip arra1 arra2
    |> Array.map (fun (x1, x2) -> x1 * x2)

