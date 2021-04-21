module MostFrequentWeekdays
open System
let mostFrequentDays (year:int) = 
    let a = DateTime(year,1,1).DayOfWeek |> string
    let b = DateTime(year,12,31).DayOfWeek |> string
    match (a ,b) with
    | (f,l) when f=l -> [f]
    | (f,l) when f = "Sunday" -> [l;f]
    | (f,l) -> [f;l]    

let mostFrequentDays1 (year:int) =  DateTime(year,1,1).DayOfWeek |> string
let mostFrequentDays2 (year:int) =  DateTime(year,12,31).DayOfWeek |> string