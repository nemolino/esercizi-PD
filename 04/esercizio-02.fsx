let rec factOpt n =
  match n with
    | 0 -> Some 1
    | _  -> if n < 0 then None
            else
             match factOpt (n-1) with
             |  Some k -> Some (n * k)
             | _  -> None

let printFact n =
    match factOpt n with
    | Some k -> string n + "! = " + string k
    | None -> "the factorial of " + string n + " is not defined"

let out1 = printFact 3
let out2 = printFact -3