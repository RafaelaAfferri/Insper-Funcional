(* Escreva uma função que calcula o n-ésimo número de Tribonacci *)
(* Tribonacci é Fibonacci com 3 termos *)

(* Apenas um treino de recursão *)
let rec tribonacci n =
    if n = 0 then
        0
    else if n = 1 then
        1
    else if n = 2 then
        1
    else
        tribonacci (n - 1) + tribonacci (n - 2) + tribonacci (n - 3)

printfn "Tribonacci de 10: %d" (tribonacci 10)

(* Uma versão mais eficiente *)
let rec iteraTribonacci quantosFaltam primeiro segundo terceiro =
    if quantosFaltam = 0 then
        primeiro
    else if quantosFaltam = 1 then
        segundo
    else if quantosFaltam = 2 then
        terceiro
    else
        let novoQuantosFaltam = quantosFaltam - 1
        let novoPrimeiro = segundo
        let novoSegundo = terceiro
        let novoTerceiro = primeiro + segundo + terceiro
        iteraTribonacci novoQuantosFaltam novoPrimeiro novoSegundo novoTerceiro

let tribonacci2 n = iteraTribonacci n 0 1 1

printfn "Tribonacci de 10: %d" (tribonacci2 10)
