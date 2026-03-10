<<<<<<< HEAD
module Greetings 

type DayPeriod = Morning | Afternoon | Evening

let makeHello (vip: string list) (name: string) =
    if List.contains name vip then 
        $"Welcome, {name}"
    else
        $"Hello, {name}"

let salute (period : DayPeriod) =
    match period with
    | Morning -> "Good Morning"
    | Evening -> "Good Evening"
    | Afternoon -> "Good Afternoon"
        
=======
namespace Greetings

[<RequireQualifiedAccess>]
module Greetings =

    let makeHello (vip: string list) (name: string) : string =
        if List.contains name vip then
            $"Welcome, {name}!"
        else
            $"Hello, {name}."

    type DayPeriod =
        | Morning
        | Afternoon
        | Evening

    let salute (period: DayPeriod) : string =
        match period with
        | Morning -> "Good Morning!"
        | Afternoon -> "Good Afternoon!"
        | Evening -> "Good Evening!"
>>>>>>> 7601d38 (feat: solutions of Aula06)
