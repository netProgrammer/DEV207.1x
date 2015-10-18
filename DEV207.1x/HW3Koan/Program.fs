open System

let goldenratio = (1.0 + Math.Sqrt(5.0)) / 2.0
let calculateRatio x = x * goldenratio
let isEven x = x % 2 = 0

let lista = [for i in 1 .. 10 do
                 if isEven i then yield calculateRatio (float i)]

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
