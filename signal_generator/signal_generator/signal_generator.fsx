
#load "packages/FSharp.Charting.0.90.7/Fsharp.Charting.fsx"
open FSharp.Charting

let generateSamples milliseconds frequency =
    let sampleRate = 44100.
    let sixteenBitSampleLimit = 32767.
    let volume = 0.8
    let toAmplitude x =
        x
        |> (*) (2. * System.Math.PI * frequency/sampleRate)
        |> sin
        |> (*) sixteenBitSampleLimit
        |> (*) volume
        |> int16
    let numOfSample = milliseconds/ 1000. * sampleRate
    let requiredSamples = seq{ 1.0 .. numOfSample}
    Seq.map toAmplitude requiredSamples
    
let points = generateSamples 150. 440.
points|> Chart.Line