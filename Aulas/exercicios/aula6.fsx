module Greetings =


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
        | Afternoon -> "Good Evening"
        


Greetings.makeHello ["rafa"; "laura"; "esther"; "ana"] "gru"



Greetings.salute Greetings.Morning



