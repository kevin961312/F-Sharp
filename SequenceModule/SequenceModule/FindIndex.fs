module FindIndex
open System

let StepsToPrime () =
    let rnd = Random()

    let IsPrime n = 
        let rec check i =
            i > n/2 || (n % i <> 0 && check (i+1)) 
        check 2


