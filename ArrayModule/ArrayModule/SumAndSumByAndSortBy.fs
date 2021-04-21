module sumFunction
// función sum
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
       |> Array.map (fun s -> s.Length)
       |> Array.sum 
getRequests()

//Funcion sumby
let getRequestsby () =
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
       |> Array.sumBy (fun s -> s.Length)

getRequestsby()


//Funcion sumby
let getRequestssumby () =
    let requests =
        [|
            "https://www.facebook.com/"
            "https://www.google.com/"
            "https://www.pluralsight.com/"
            "https://99.99.99.99/doesntexist"
            "https://www.Amazon.com/"
            "https://www.Twitter.com/"
            "https://www.gmail.com/"
        |]
    
    use wc = new WebClient()

    requests
    |> Array.choose (fun  url ->  
       try
         (url, wc.DownloadString(url).Length) |> Some
       with
       |_ -> None)
       |> Array.sortBy (fun (url, length) -> -length)

getRequestssumby()