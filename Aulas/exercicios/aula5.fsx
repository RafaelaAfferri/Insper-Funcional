let apply_twice f x = f (f x)

let double x = x * 2

let show_result x = printfn "%d" x

let square x = x * x


let exercicio1 =  square >> double >> show_result

let x = 3

exercicio1 x

let apply_twice2 f = f >> f 


let doubleSquare = double (square x)


apply_twice2 sqrt 16.0