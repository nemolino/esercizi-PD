let rec cmpLength xs ys =
    match xs,ys with
    | [],[] -> 0
    | x::xs,[] -> 1
    | [],y::ys -> -1
    | _::xs,_::ys -> cmpLength xs ys

let out1 = cmpLength [1..10] ['a'..'z']
let out2 = cmpLength [1..26] ['a'..'z']
let out3 = cmpLength ['a';'b';'c'] ["e";"f"] 