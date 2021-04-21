module AccessingArrayElements

open System

let lastDays year = 
    [|
        for i in 1..12 do
            let firstDay = DateTime(year,i,1)
            let dayCount = float(DateTime.DaysInMonth(year,i))
            let lastDay = firstDay.AddDays(dayCount-1.)
            let lastDatExcel = 
                if firstDay = DateTime(1900,2,1) then   
                    29 
                else
                    lastDay.Day
            yield lastDatExcel
    |]

lastDays 1900