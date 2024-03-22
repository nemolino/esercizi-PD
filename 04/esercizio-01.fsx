type month = January | February | March | April | 
                May | June | July | August | September| 
                October | November | December

let daysOfMonth m =
    match m with
    | February                            -> 28
    | April | June | September | November -> 30
    | _                                   -> 31

type yearType = Leap | NoLeap

let daysOfMonth1 m y =
    match m with
    | February -> if y = Leap then 29 else 28
    | _ -> daysOfMonth m

let out1 = daysOfMonth1 February Leap
let out2 = daysOfMonth1 February NoLeap

// ----------------------------------------------------------------------------

// assunzione : n > 0
let leap n =
    if n % 4 = 0 && (n % 100 <> 0 || n % 400 = 0) 
    then Leap 
    else NoLeap

let out3 = leap 1900
let out4 = leap 1901
let out5 = leap 1912
let out6 = leap 2000

// ----------------------------------------------------------------------------

let daysOfMonth2 m y =
    daysOfMonth1 m (leap y)

let out7 = daysOfMonth2 February 1901
let out8 = daysOfMonth2 February 1912
let out9 = daysOfMonth2 March 1901
let out10 = daysOfMonth2 March 1912