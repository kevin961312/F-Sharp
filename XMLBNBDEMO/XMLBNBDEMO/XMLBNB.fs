module XMLBNB

open FSharp.Data
open System

let private ProfileClasses =
    [
        00
        01
        02
        03
        04
        05
        06
        07
        08
    ] |> Set.ofList

type ProfileClass (value : int) = 
    do 
        if ProfileClasses |> Set.contains value |> not then
            raise(Exception("Invalid ProfileClass"))
    override _.ToString() = sprintf "%02i" value

type MeterTimeswitchClass (value : int) =
    do 
        if value < 1 || value > 999 then 
            raise(Exception("Invalid ProfileClass"))
    override _.ToString() = sprintf "%03i" value

type LineLossFactorClass (value: int) =
    do 
        if value < 1 || value > 999 then 
            raise(Exception("Invalid LineLossFactorClass"))
    override _.ToString() = sprintf "%03i" value


type DistributiorId (value : int) = 
    do 
        if ProfileClasses |> Set.contains value |> not then
            raise(Exception("Invalid ProfileClass"))
    override _.ToString() = sprintf "%02i" value
