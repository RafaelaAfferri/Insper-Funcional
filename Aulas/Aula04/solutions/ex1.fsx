(* 
Faça uma função chamada *describe_number* que retorna o nome em string de 
um número até 5. Retorne "outro" para números maiores que 5.
*)

let describe_number n =
    match n with
    | 1 -> "um"
    | 2 -> "dois"
    | 3 -> "três"
    | 4 -> "quatro"
    | 5 -> "cinco"
    | _ -> "outro"

// Testes
printfn "%s" (describe_number 1) // "um"
printfn "%s" (describe_number 3) // "três"
printfn "%s" (describe_number 5) // "cinco"
printfn "%s" (describe_number 6) // "outro"
