<<<<<<< HEAD
﻿// For more information see https://aka.ms/fsharp-console-apps
open Greetings
printfn "Hello from F#"


printfn "%s" (makeHello ["rafa"; "laura"; "esther"; "ana"] "gru")
printfn "%s" (salute Morning)
=======
﻿open Greetings

let vipList = ["Alice"; "Bob"; "Charlie"; "Douglas"]

printfn "%s" (Greetings.makeHello vipList "Ed")
printfn "%s" (Greetings.makeHello vipList "Douglas")

printfn "%s" (Greetings.salute Greetings.DayPeriod.Afternoon)
>>>>>>> 7601d38 (feat: solutions of Aula06)
