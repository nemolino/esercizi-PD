let rec rmEven xs =
    match xs with 
    | [] -> []
    | y :: ys -> if y % 2 = 0 
                 then rmEven ys 
                 else y :: rmEven ys

let out1 = rmEven [-10 .. 10 ] 
let out2 = rmEven [2; 5; 5; 6; 6; 87; 6; 100; 2]