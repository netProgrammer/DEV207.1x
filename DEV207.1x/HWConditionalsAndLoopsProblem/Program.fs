//http://pastebin.com/6inB5LRd
open System

let outputName i name = (string i) + " " + name 

let uotputResult i name age =
   if age >= 20 then ((outputName i name) + " is no longer a teenager.\n") //If age >= 20 then the field is a string which states the person's name and that they are no longer a teenager
   elif age < 20 && age > 13  then ((outputName i name) + " is a teenager.\n") //If the age < 20 and greater than 13 then the field is a string that states the persons name and that they are a teenage
   elif age < 13 then ((outputName i name) + " is a kid or child.\n") //If the age is < than 13 then is states the name and the person is a kid or child.
   else ((outputName i name) + " is 13 years old.\n") //age 13

let rec processPeople i data =
   Console.Write("name : ")
   let name = Console.ReadLine()
   if name = "exit" then
      Console.WriteLine("Entering is over.")
      Console.WriteLine()
      data
   else
      Console.Write("age : ")
      let canparse, age = Int32.TryParse(Console.ReadLine())
      if canparse then
            Console.WriteLine("Please enter "  + string (i+1) + " person or 'exit'.")
            processPeople (i + 1) (data + (uotputResult i name age))
      else  Console.WriteLine("The age is wrong. Try again enter the name and age of a person")
            processPeople i data
   
[<EntryPoint>]
let main argv = 
    Console.WriteLine("Please enter the name and age of a person or 'exit'")
    Console.Write((processPeople 1 ""))
    Console.ReadKey()
    0 // return an integer exit code
