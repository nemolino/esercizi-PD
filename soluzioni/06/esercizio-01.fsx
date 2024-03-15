let rec map f xs =
    match xs with 
    | [] -> []
    | y :: ys -> (f y) :: map f ys

let out1 = map (fun x -> x * x) [1..20]

let rec mapF f xs =
    List.foldBack (fun x acc -> (f x) :: acc) xs []

let out1_bis = mapF (fun x -> x * x) [1..20]

// ----------------------------------------------------------------------------

let rec filter pred xs =
    match xs with 
    | [] -> []
    | y :: ys -> if pred y 
                 then y :: filter pred ys
                 else filter pred ys

let out2 = filter (fun x -> x % 3 = 0) [1..20]

let filterF pred xs =
    List.foldBack (fun x acc -> if pred x then x :: acc else acc) xs []

let out2_bis = filterF (fun x -> x % 3 = 0) [1..20]

// ----------------------------------------------------------------------------

let rec exists pred xs =
    match xs with 
    | [] -> false
    | y :: ys -> if pred y 
                 then true
                 else exists pred ys

let out3 = exists (fun x -> x % 3 = 0) [1..20]
let out4 = exists (fun x -> x % 21 = 0) [1..20]

let existsF pred xs =
    List.foldBack (fun x acc -> pred x || acc) xs false

let out3_bis = existsF (fun x -> x % 3 = 0) [1..20]
let out4_bis = existsF (fun x -> x % 21 = 0) [1..20]

// ----------------------------------------------------------------------------

let rec forall pred xs =
    match xs with 
    | [] -> true
    | y :: ys -> if pred y 
                 then forall pred ys
                 else false

let out5 = forall (fun x -> x < 21) [1..20]
let out6 = forall (fun x -> x < 18) [1..20]

let forallF pred xs =
    List.foldBack (fun x acc -> pred x && acc) xs true

let out5_bis = forallF (fun x -> x < 21) [1..20]
let out6_bis = forallF (fun x -> x < 18) [1..20]