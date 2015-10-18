//http://pastebin.com/zaXY0Q3j
open System
let goldenratio = (1.0 + sqrt(5.0)) / 2.0

type goldenpair = {
  value: int
  ratio: float
}

let calcgoldenratio x = x * goldenratio

let GetRatio inputvalue = {
  value = inputvalue
  ratio = calcgoldenratio (float inputvalue)
}

[<EntryPoint>]
let main argv = 
    let values = [ let mutable run = true
                   while run do
                      Console.WriteLine("Do you want to add value to list (y/n)?")
                      if Console.ReadLine().ToLower() = "y"
                      then 
                           Console.WriteLine("Enter value: ")
                           let canparse, value = Int32.TryParse(Console.ReadLine())
                           if canparse then yield GetRatio (int value)
                           else Console.WriteLine("Wrong value !!!")                           
                      else run <- false]
    
    for x in values do
        Console.WriteLine("value {0} - ratio {1}", x.value, x.ratio)
    Console.ReadKey();
    0 // return an integer exit code
