let rec remove x ys =
    match ys with 
    | [] -> []
    | y::ys -> if x = y 
                then remove x ys 
                else y :: remove x ys

let out1 = remove 2 [0..10]
let out2 = remove "uva" ["mele";"uva";"pere";"uva";"banane";"uva"]
let out3 = remove 11 [0..10]

let rec removeDup xs =
    match xs with 
    | [] -> []
    | y::ys -> y :: removeDup (remove y ys)

let out4 = removeDup [1; 2; 1; 2; 3] 
let out5 = removeDup ["mele";"uva";"mele";"pere";"uva";"banane";"uva";"pere";"pere";"banane"] 