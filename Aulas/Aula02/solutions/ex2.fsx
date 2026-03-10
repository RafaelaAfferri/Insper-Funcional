(* Escreva uma função que recebe 3 números e retorna o maior *)
let max3 a b c =
    if a > b then
        if a > c then a else c
    else if b > c then
        b
    else
        c

(* Alternativa usando AND *)
printfn "%d" (max3 1 2 3)
printfn "%d" (max3 1 4 3)
printfn "%d" (max3 5 2 3)

let max3Alternative a b c =
    if a > b && a > c then a
    else if b > c then b
    else c

printfn "%d" (max3Alternative 1 2 3)
printfn "%d" (max3Alternative 1 4 3)
printfn "%d" (max3Alternative 5 2 3)
