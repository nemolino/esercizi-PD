let rec rmOddPos xs =
    match xs with
    | [] -> []
    | [y_even] -> [y_even]
    | y_even :: _ :: ys -> y_even :: rmOddPos(ys)

let out1 = rmOddPos ['a'..'z'] 
let out2 = rmOddPos ["zero" ; "uno" ; "due" ; "tre" ; "quattro"]