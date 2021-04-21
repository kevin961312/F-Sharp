module ContainAllRots

let containAllRots (strng : string) a  =
    [for i in 0 .. strng.Length-1 -> strng.Substring(i,strng.Length-i) + strng.Substring(0,i) ] 
    |> List.forall (fun s -> a |>List.contains s)

containAllRots "casa" ["aaa"]