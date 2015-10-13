open System

let rec dosomethingrandom (x : int) =
  if x = 0 then 1
  else dosomethingrandom (x - 1) * x

[<EntryPoint>]
let main argv = 
   Console.Write("Please enter number : ")
   let canparse, x = Int32.TryParse(Console.ReadLine())
   if canparse then Console.WriteLine("Result is " + (string (dosomethingrandom x)))
   else  Console.WriteLine("The input is wrong")
   Console.ReadKey()
   0 // return an integer exit code