open System
 
let goldenRatio = (1.0 + Math.Sqrt(5.0)) / 2.0
 
let getResultTuple number =
    (number, float number * goldenRatio)
 
[<EntryPoint>]
let main argv =
    let numbers =
        [ let mutable run = true
        while run do
            Console.Write "Enter a number: "
            let canparse, number = Double.TryParse(Console.ReadLine())
            if canparse then
                yield getResultTuple number
            else
                Console.WriteLine "Could not parse that number."
            Console.WriteLine "Do you want to add more numbers (y/n)? "
            if Console.ReadLine().ToLower() = "n" then
                run <- false ]
 
    for x in numbers do
        let originalNumber, result = x
        printf "(%f , %f)\n" originalNumber result
    Console.ReadKey()
    0 // return an integer exit code