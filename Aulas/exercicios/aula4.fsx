let int_to_string i =

    let result = 
        match i with
            | 0 -> "zero"
            | 1 -> "one"
            | 2 -> "two"
            | 3 -> "three"
            | 4 -> "four"
            | 5 -> "five"
            | _ -> "other"
    printfn $"{i}"
    result

int_to_string 7




type day = Sun | Mon | Tue | Wed | Thu | Fri | Sat
let int_to_day (i: int) : day =
    match i % 7 with
    | 0 -> Sun
    | 1 -> Mon
    | 2 -> Tue
    | 3 -> Wed
    | 4 -> Thu
    | 5 -> Fri
    | 6 -> Sat
    | _ -> failwith "This should never happen"




let list = [1; 2; 3; 4; 5]

printf $"{list}"

let rec sum_list lst =
    match lst with
    | [] -> 0.0 (* Lista vazia *)
    | h :: t -> h + sum_list t (* Desempacota head do tail *)
let my_list = [ 1.1; 2.1; 3.0; 4.0; 5.0 ]
printfn "Sum: %f\n" (sum_list my_list)



let lst = [10; 20; 30; 40; 50]
let x = lst[2] (* x = 30 *)

let my_list = [1; 2; 3]
let x = List.item 2 


my_list |> List.item 2 (* x = 3 *)



//Exercicios


//1. Faça uma função que retorna a quantidade de elementos em uma lista. Não usar built-in List.length .

let rec tam_lista  n = 
    match n with
    | [] -> 0
    | h :: t -> 1 + tam_lista t

tam_lista [1;2;3;4]

//2. Faça uma função que retorna o maior elemento de uma lista.

let rec maior_ele n =
    match n with
    | [] -> 0
    | [x] -> x
    | h :: t -> 
        let max_tail = maior_ele t in 
        if h > max_tail then h else max_tail
    printfn "%d" max_tail

maior_ele [1;2;3;4]




//3. Faça uma função que retorna o segundo maior elemento de uma lista.

let rec segundo_maior n =
    match n with
    | [] -> failwith "Lista vazia"
    | [x] -> failwith "Lista com apenas um elemento"
    | [h1; h2] -> if h1 > h2 then h2 else h1
    | h :: t -> 
        
