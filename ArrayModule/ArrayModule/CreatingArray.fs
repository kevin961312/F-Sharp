module CreatingArray

let primes = [|1; 2; 3; 5; 7; 11; 13; 17; 19; 23; 29; 31; 37; 41; 43 |]

let animals = 
    [|
        "Dog"
        "Cat"
        "Zebra"
    |]

let RangeNormal = [|1..100|]

let RangeSum5 = [|50..5..200|]

let RangeFloat = [|50.0 .. 5.3 .. 200.0|]

let smallEvens = [|for element in 1..100 do if element%2=0 then yield element|]

open System
let lastDays year = 
    [|
        for i in 1..12 do
            let firstDay = DateTime(year,i,1)
            let lastDay = firstDay.AddDays(float(DateTime.DaysInMonth(year,i)-1))
            yield lastDay.Date
    |]

lastDays 2015

let NotUseful = Array.create 100 3.3

let emptyStrings : string [] = Array.zeroCreate 100 

let emptyInt : int [] = Array.zeroCreate 100 

let emptyFloat : float [] = Array.zeroCreate 100 

open System
let  lastDays2 year =
    Array.init 12 (fun i ->
        let month = i+1
        let firstDay = DateTime(year,month,1)
        let lastDay = firstDay.AddDays(float(DateTime.DaysInMonth(year,month)-1))
        lastDay
    )

open System.IO

let files = 
    Directory.EnumerateFiles(@"C:\Users\kevin.pineda\Desktop\Databases File")
    |> Array.ofSeq
            
