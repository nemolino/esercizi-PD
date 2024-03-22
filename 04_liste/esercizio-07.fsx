// assumo n >= 0
let rec downTo n =
    match n with
    | 0 -> [0]
    | n -> n :: downTo (n-1)

let out1  = downTo 10


// assumo n >= 0
let rec upTo n =
    match n with
    | 0 -> [0]
    | n -> upTo (n-1) @ [n] 
    
let out2  = upTo 10