let RandomFruits count = 
    let r = System.Random()
    let fruits = [|"apple"; "Orange" ; "Pear"|]
    Array.init count (fun _ ->
        let index = r.Next(3)
        fruits.[index])


let squares = [|for i in 0..99 do yield i*i|]

let EvenSquares = Array.filter ( fun x -> x % 2 = 0) squares