(* Escreva uma função que retorna o próximo primo *)

let rec achaDivisor n d =
    if d >= n then false
    elif n % d = 0 then true
    else achaDivisor n (d + 1)

let is_prime n =
    if n <= 1 then false else not (achaDivisor n 2)

let rec next_prime n =
    let candidate = n + 1
    if is_prime candidate then candidate  (* Pronto, achamos o próximo primo *)
    else next_prime candidate  (* Continua procurando *)

(* Imprime resultados de teste *)
let imprimeProximoPrimo n =
    let p = next_prime n
    printfn "O próximo primo depois de %d é %d" n p

imprimeProximoPrimo 14
imprimeProximoPrimo 100
imprimeProximoPrimo 1000
