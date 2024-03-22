let orb x y =
    match (x,y) with
    | (false, false) -> false
    | _ -> true

let out1 = orb true true
let out2 = orb true false
let out3 = orb false true
let out4 = orb false false