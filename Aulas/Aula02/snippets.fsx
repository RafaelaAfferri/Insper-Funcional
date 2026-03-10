(* Snippets da Aula 02*)

(* Initial *)
let x = 7
printfn $"{x}"

(* Let *)
// let x = 2

(* Bug *)
// let x = 2 + 2.5

(* Correct *)
// let x = 2. + 2.5

(* let expression *)
let x = 1 in x
(let x = 2 in 3 * x) + 1

(* concat *)
// let x = "A"
// let y = "B"
// let z = x + y

(* Nested scope *)
// let x = 5 in let y = 2 in x + y
// let x = 5 in (let x = 6 in x) + x

(* Redefinition of bound variable *)
let x = 1 ;;
let x = 2 ;; (* Whaat? *)
x

//

// let x = 1 in
//     let x = 2 in
//         x

(* if expressions *)
// if 2 > 1 then 3 else 2

(* functions *)
// let f x = x + 1
// let g x y = x + y

(* function application *)
// f 2
// g 2 3

// (* currying *)
// g (2 + 1)

// let g x y = x + y
// let plus2 = g 2
// plus2 3

// let g x y = x + y
// printfn $"{g 2 3}"
// printfn $"{(g 2) 3}"

(* More about functions *)
// let double x = x * 2
// let inc f = fun x -> (f x) + 1 (* CLOSURE! *)
// let double_inc = inc double

// double_inc 3 (* 7 *)

(* lambdas *)
// (fun x -> x + 1)
// let inc = fun x -> x + 1

// let inc x = x + 1

(* Bug *)
// fun x -> x + 1 22

(* Correto *)
// (fun x -> x + 1) 22

(* Funções recursivas *)
// let rec fact n = if n = 0 then 1 else n * fact (n - 1)
