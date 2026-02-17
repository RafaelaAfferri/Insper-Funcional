(* Faça uma função que retorna o maior elemento de uma lista. *)
let maximumOf a b = if a > b then a else b

let rec maxElement list =
    match list with
    | [] -> failwith "empty list"
    | [ x ] -> x
    | h :: t -> maximumOf h (maxElement t)

// Testes
printfn "%d" (maxElement [ 1; 2; 3; 4; 5 ]) //> 5
printfn "%d" (maxElement [ 5; 4; 3; 2; 1 ]) //> 5
printfn "%d" (maxElement [ 1; 3; 2; 5; 4 ]) //> 5