let rec split xs =
    match xs with 
    | [] -> ([],[])
    | [y_even] -> ([y_even],[])
    | y_even :: y_odd :: ys -> 
        let (evens, odds) = split ys
        (y_even :: evens, y_odd :: odds)  

let out1 = split [0 .. 9]
let out2 = split ["ciao"] 
let out3 = split ["ciao" ; "ciao!!!" ]  
let out4 = split [ 'a' .. 'k'] 