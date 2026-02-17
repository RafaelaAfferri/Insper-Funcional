(* Altere o type Person para incluir o e-mail. Faça uma função para verificar se um e-mail existe ou não no record *)

(* O tipo original *)
// type person =
//     { name: string
//       age: int
//       country: string }

(* Solução imediata - vai dar problema com os dados*)
// type person =
//     { name: string
//       age: int
//       country: string
//       email: string }

(* Solução legada - herança estrutural *)
// type person =
//     { name: string
//       age: int
//       country: string }

// type person_email = { p: person; email: string }

// let raul =
//     { p =
//         { age = 40
//           name = "Raul"
//           country = "Brazil" }
//       email = "a@a.com" }

(* Solução legada - optional extension *)
// type person =
//     { name: string
//       age: int
//       country: string
//       email: string option }

// let unreachableRaul =
//     { age = 40
//       name = "Raul"
//       country = "Brazil"
//       email = None }

// let raul =
//     { age = 40
//       name = "Raul"
//       country = "Brazil"
//       email = Some "a@a.com" }

(* Solução: union type composition *)
type personBasic =
    { name: string
      age: int
      country: string }

type personWithEmail =
    { name: string
      age: int
      country: string
      email: string }

type Person =
    | Basic of personBasic
    | Email of personWithEmail

let raul1 =
    Basic
        { age = 40
          name = "Raul"
          country = "Brazil" }

let raul2 =
    Email
        { age = 40
          name = "Raul"
          country = "Brazil"
          email = "a@a.com" }

(* Testing the union type. This is where match expressions shine! *)
let checkEmail person input =
    match person with
    | Basic _ -> false
    | Email { email = email } when email = input -> true
    | _ -> false

printfn "%b" (checkEmail raul1 "a@a.com")
printfn "%b" (checkEmail raul2 "a@a.com")