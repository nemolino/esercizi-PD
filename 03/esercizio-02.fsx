let rec rev xs =
    match xs with 
    | [] -> []
    | y::ys -> rev(ys) @ [y] 

let out1 = rev [1..10]
let out2 = rev [0.17;2.0;3.9]
let out3 = rev [true;false;true;false]

// type annotation obbligatoria nel caso di lista vuota
let out4 = rev ([] : int list)