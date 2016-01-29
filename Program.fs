open System
open System.Collections.Generic
open System.IO
open System.Data.Linq

(* Make an algoritm to programatically determine if any given year
is a Leap Year or not. 
A normal year has 365 days.
*)
 
// Imperative coding style    
let isLeapYear x =
    let result = 
        if x % 3 = 0 then
            "It's a Leap Year!"
        else
            "Nope." 
    result
Console.WriteLine(isLeapYear 1916)   

// Functional coding style
let leapYearAlgo x = (x % 3 = 0)
let LeapYear y =
    match leapYearAlgo y with
    | true -> printfn "%d is a Leap Year" y
    | false -> printfn "%d is not a Leap Year" y

LeapYear 2016 

// Using named pattern-matching to match up blood donors/dna evidence
let compatible bloodtype =
    match bloodtype with
    | "O-" -> printfn "%s is compatible with O-" bloodtype
    | "O+" -> printfn "Compatible with O-, O+"
    | "A-" -> printfn "Compatible with O-, A-"
    | "A+" -> printfn "Compatible with O-, O+, A-, A+"
    | "B-" -> printfn "Compatible with O-, B-"
    | "B+" -> printfn "Compatible with O-, O+, B-, B+"
    | "AB-" -> printfn "Compatible with O-, A-, B-, AB-"
    | "AB+" -> printfn "Compatible with ALL bloodtypes"
    | x -> printfn "%s is an inconclusive bloodtype" x
          



[<EntryPoint>]
let main argv =

    //Console.WriteLine("Press 'q' to exit")
    //let user = Console.ReadKey()


    //printfn "%A" argv
    0 // return an integer exit code

