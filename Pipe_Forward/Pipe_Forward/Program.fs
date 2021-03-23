sin 7.

7. |> sin

7. 
    |> sin
    |> ((*)2.)

let square x = x*x

3|> double |> square

[1;2;3;4;5;6;7;8;9;]
    |> List.filter (fun element -> element % 3 = 0 || element % 2 = 1)
    |> List.map ((*)2)
    |> List.sum

let (|<><><>|) a f = f a

3 |<><><>| double |<><><>| square