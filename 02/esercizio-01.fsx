// assunzione : n >= 0
let rec exp b n =
    match n with
    | 0 -> 1.0
    | _ -> b * exp b (n-1)

let out1 = exp 2.0 0
let out2 = exp -2.3 7
let out3 = exp 6.0 3