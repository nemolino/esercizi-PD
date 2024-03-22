let rec length xs =
    match xs with
    | [] -> 0
    | _ :: ys -> 1 + length(ys)

let out1 = length []
let out2 = length [1;2;3]
let out3 = length [1..18]