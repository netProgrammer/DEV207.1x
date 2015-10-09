open System

[<EntryPoint>]
let main argv = 
    let mutable a = 100
    let b = 1000

    a <- 101

    let f x y = x + y / 10

    Console.WriteLine("Result " + (string (f a b)))
    Console.ReadKey()
    0 // return an integer exit code
