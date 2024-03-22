// assunzione : n >= 0
let rec make_str x =
    match x with
    | 0 -> "0"
    | _ -> make_str (x-1) + " " + string x

let out1 = make_str 20

// ----------------------------------------------------------------------------

// assunzione : n >= 0
let rec make_sum_str x =
    match x with
    | 0 -> (x, "0")
    | _ -> 
        let (y_sum, y_str) = make_sum_str (x-1)
        (x + y_sum, y_str + " " + string x)

let out2 = make_sum_str 5

// ----------------------------------------------------------------------------

// assunzione : n >= 0
let somma_n n =

    let rec make_sum_str_1 x =
        match x with
        | 0 -> (x, "0")
        | _ -> 
            let (y_sum, y_str) = make_sum_str_1 (x-1)
            (x + y_sum, y_str + " + " + string x)

    let (sum, str) = make_sum_str_1 n
    str + " = " + string sum

let out3 = somma_n 5
let out4 = somma_n 10