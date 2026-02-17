(* Faça uma função que retorna o segundo maior elemento de uma lista. *)

(* Retorna uma tupla com o maior e o segundo maior elemento *)
let rec topTwoElements list =
    match list with
    | [] -> failwith "empty list"
    | [ _ ] -> failwith "list with only one element"
    | [ x1; x2 ] -> if x1 > x2 then (x1, x2) else (x2, x1)
    | h :: t ->
        let max_tail, second_max_tail = topTwoElements t in

        if h > max_tail then (h, max_tail)
        else if h > second_max_tail then (max_tail, h)
        else (max_tail, second_max_tail)

let secondMaxElement list =
    let _, second_max = topTwoElements list
    second_max


(* Testes *)
printfn "%d" (secondMaxElement [1; 2; 3; 4; 5])
printfn "%d" (secondMaxElement [5; 4; 3; 2; 1])
printfn "%d" (secondMaxElement [1; 3; 2; 5; 4])
printfn "%d" (secondMaxElement [3; 4])
