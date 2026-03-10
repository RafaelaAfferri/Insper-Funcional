//exercicio 1

let hash n (x:float) = x**2 % n
let hash10 = hash 10
hash10 3.0




//exercicio 2

let maior a b c = List.max [a; b; c]

maior 2 7 4

// exercicio 3


let rec somaDig a =
    if a < 10 then a
    else let d = a % 10 in printfn "%d" d; (d) + somaDig (a / 10)


somaDig 4578

//exercicio 4

let rec triBonnaci n =
    if n = 0 || n = 1 then 0
    elif n = 2 then 1
    else triBonnaci(n-3) + triBonnaci(n-2) + triBonnaci(n-1)

triBonnaci 8

//exercicio 5



