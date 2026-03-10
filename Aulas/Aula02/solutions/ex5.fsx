(* Escreva uma função que verifica se um número é primo *)

(* Função para achar se tem algum divisor de n a partir de d que seja menor que n *)
let rec achaDivisor n d =
    if d >= n then false
    elif n % d = 0 then true
    else achaDivisor n (d + 1)

let is_prime n =
    if n <= 1 then false else not (achaDivisor n 2)

(* Imprime resultados de teste *)
let imprimeQuandoForPrimo n =
    if is_prime n then
        printfn "%d é primo" n
    else
        (* Não faz nada se não for primo, retorna o unit - aquele valor especial
           que não tem significado *)
        ()

let rec imprimeResultadosTeste minNum maxNum =
    if minNum > maxNum then
        ()
    else
        imprimeQuandoForPrimo minNum
        imprimeResultadosTeste (minNum + 1) maxNum

imprimeResultadosTeste 0 20
