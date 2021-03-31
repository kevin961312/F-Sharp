try
    failwith "An Error Message"
with 
    | Failure msg -> printfn "Failed with %s" msg