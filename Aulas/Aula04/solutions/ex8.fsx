(* Fazer uma função que altera todas as ocorrências de uma lista. *)

let rec replaceAll list oldValue newValue =
    match list with
    | [] -> []
    | h :: t ->
        let new_t = replaceAll t oldValue newValue
        if h = oldValue then newValue :: new_t else h :: new_t

(* Testes *)

(* Works with integers *)
let list1 = [ 1; 2; 3; 2; 4 ]
let result1 = replaceAll list1 2 5
printfn "Original list: %A" list1 // Output: [1; 2; 3; 2; 4]
printfn "Modified list (with 2 replaced by 5): %A" result1 // Output: [1; 5; 3; 5; 4]

(* Works with strings as well! How is this possible? *)
let list2 = [ "apple"; "banana"; "apple"; "cherry" ]
let result2 = replaceAll list2 "apple" "orange"
printfn "Original list: %A" list2 // Output: ["apple"; "banana"; "apple"; "cherry"]
printfn "Modified list (with 'apple' replaced by 'orange'): %A" result2 // Output: ["orange"; "banana"; "orange"; "cherry"]
