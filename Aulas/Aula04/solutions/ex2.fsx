(*
Faça uma função que recebe uma tupla (x, y) e retorna um texto indicando 
se x e y são iguais, x é maior ou y é maior.
*)

let compare_points inputTuple = 
  match inputTuple with
  | x, y when x = y -> "x e y são iguais"
  | x, y when x > y -> "x é maior que y"
  | _ -> "y é maior que x"

// Testes
printfn "%s" (compare_points (3, 3)) // "x e y são iguais"
printfn "%s" (compare_points (5, 2)) // "x é maior que y"
printfn "%s" (compare_points (1, 4)) // "y é maior que x"
