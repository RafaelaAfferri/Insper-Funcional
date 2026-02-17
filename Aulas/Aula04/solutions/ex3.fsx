(*
Faça uma função que retorna a quantidade de elementos em uma lista. 
Não usar built-in function List.length.
*)

let rec countElements xs =
    match xs with
    | [] -> 0
    | _ :: tail -> 1 + countElements tail

(* com tail call optmization *)
let countElementsTailOptim xs =
    let rec auxFn xs acc =
        match xs with
        | [] -> acc
        | _ :: tail -> auxFn tail (acc + 1) in

    auxFn xs 0

// Testes
let testList = [1; 2; 3; 4; 5]
printfn "Quantidade de elementos (recursivo): %d" (countElements testList)
printfn "Quantidade de elementos (tail call optimization): %d" (countElementsTailOptim testList)
