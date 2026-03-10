(* Escreva uma função que calcula um hash simples: h(x) = (x^2 mod n) *)

(* Considerando n constante um primo muito grande *)
let hash x = let n = 104729 in (x * x) % n
printfn "%d" (hash 1234567890)

(* Alternativa: n é um argumento da função *)
let hashAlternative n x = (x * x) % n
printfn "%d" (hashAlternative 104729 1234567890)
