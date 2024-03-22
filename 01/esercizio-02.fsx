let isPari x = x % 2 = 0

(*
let isPariString x =
    match isPari(x) with
    | true -> "pari"
    | false -> "dispari"
*)

let isPariString x = 
    if isPari(x) then "pari" else "dispari"

let out1 = isPariString(4)
let out2 = isPariString(5)

let isPariString1 x = 
    string x + " è un numero " + isPariString(x)

let out3 = isPariString1(4)
let out4 = isPariString1(5)