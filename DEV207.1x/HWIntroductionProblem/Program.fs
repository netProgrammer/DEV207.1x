open System

let volumeOfCylinder (r: float) (h: float) = Math.PI * Math.Pow(r, 2.0) * h

[<EntryPoint>]    
let main argv =
    Console.Write("Please enter radius : ")
    let r = float (Console.ReadLine())
    Console.Write("Please enter height : ")
    let h = float (Console.ReadLine())
    let volume = volumeOfCylinder r h
    Console.WriteLine("Volume of cylinder is" + (string volume))
    Console.ReadKey()
    0 // return an integer exit code