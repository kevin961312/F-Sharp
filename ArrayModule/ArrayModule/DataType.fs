module DataType
open  System
open System.Net
let getRequests () =
    let requests =
        [|
            "https://www.facebook.com/"
            "https://www.google.com/"
            "https://www.pluralsight.com/"
            "https://99.99.99.99/doesntexist"
        |]
    
    use wc = new WebClient()

    requests
    |> Array.choose (fun  url ->  
       try
         wc.DownloadString(url) |> Some
       with
       |_ -> None)
    |> Array.iter (fun s -> printf "Content: %s" (s.Trim().Substring(0,100)))

getRequests()
