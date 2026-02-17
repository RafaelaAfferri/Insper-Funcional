(*
Faça uma função que entra um record no formato do exemplo e retorna 
se a pessoa é maior de idade ou não.
*)

type person =
    { name: string
      age: int
      country: string }

(* First implementation using pattern matching. This is overkill. *)
let isAdult person =
    match person with
    | { age = age } when age >= 18 -> true
    | _ -> false

(* Second implementation using direct field access. This is simpler. *)
let isAdult2 person = person.age >= 18

(* Tests. *)
let person1 =
    { name = "Alice"
      age = 20
      country = "USA" }

let person2 =
    { name = "Bob"
      age = 16
      country = "UK" }

printfn "%s (aged %d) is an adult: %b" person1.name person1.age (isAdult person1)
printfn "%s (aged %d) is an adult: %b" person2.name person2.age (isAdult person2)

printfn "%s (aged %d) is an adult: %b" person1.name person1.age (isAdult2 person1)
printfn "%s (aged %d) is an adult: %b" person2.name person2.age (isAdult2 person2)
