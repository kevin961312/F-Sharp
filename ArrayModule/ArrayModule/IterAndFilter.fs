module IterAndFilter
// función iter y iteri
let vowelPositions (str: string) =
    let Vowels = "aeiouAEIOU"
    str.ToCharArray()
    |> Array.iteri (fun i c -> if Vowels.Contains(c.ToString()) then
                                printfn "Vowel at position %i %c" i c)
                              
vowelPositions "Pluralsight"

// función filter

open System

let LastDays year =
    [|
        for i in 1..12 do
            let firstday = DateTime(year, i , 1)
            let dayCount = float(DateTime.DaysInMonth(year, i))
            let lastDay = firstday.AddDays(dayCount - 1.)
            yield lastDay
    |]

let isWeekend (day: DateTime) =
    day.DayOfWeek = DayOfWeek.Saturday || day.DayOfWeek = DayOfWeek.Sunday

let WarningDays year = 
    LastDays year
    |> Array.filter isWeekend

WarningDays 2015