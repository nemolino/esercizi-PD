let rec swap xs =
    match xs with
    | y_left :: y_right :: ys -> y_right :: y_left :: swap ys
    | _ -> xs

let out1 = swap [1 .. 6]
let out2 = swap [1 .. 7]
let out3 = swap ['a'; 'b'; 'c']