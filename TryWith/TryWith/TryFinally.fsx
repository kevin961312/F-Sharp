try 
    try
        failwith "An Error Message"
    with 
        | Failure msg -> printfn "Failed with %s" msg
finally
    printfn "This  always evaluates"



try 
    try
        failwith "An error messages"
    finally
        printfn "This  always evaluates"
with
    | Failure msg -> printfn "Failed with %s" msg