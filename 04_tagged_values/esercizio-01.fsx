type figura = 
   | Rettangolo of  float * float
   | Quadrato   of  float
   | Triangolo  of  float * float

let area fig =
   match fig with
   | Rettangolo(b,h) -> b * h     
   | Quadrato l -> l * l  
   | Triangolo(b,h) -> ( b * h ) / 2.0 

let well_formed fig =
   match fig with
   | Rettangolo(b,h) | Triangolo(b,h) -> b >= 0 && h >= 0     
   | Quadrato l -> l >= 0 

let areaOpt fig =
    if well_formed fig 
    then Some(area fig) 
    else None

let out1 = areaOpt ( Rettangolo(2.0,3.0) ) 
let out2 = areaOpt ( Rettangolo(2.0, -3.0) ) 
let out3 =  areaOpt ( Triangolo(2.5, 3.6) )
let out4 =  areaOpt ( Triangolo(-2.5, 3.6) )

// ----------------------------------------------------------------------------

let printArea fig =
    if well_formed fig 
    then "area: " + string (area fig)
    else "la figura non è ben definita"

let out5 = printArea ( Quadrato 10.0 ) 
let out6 = printArea ( Quadrato -10.0 ) 

// ----------------------------------------------------------------------------

let sommaArea fig1 fig2 =
    if well_formed fig1 && well_formed fig2 
    then Some(area fig1 + area fig2)
    else None

let out7 = sommaArea  ( Rettangolo(2.,5.) )  ( Quadrato 10. )
let out8 = sommaArea  ( Rettangolo(2.,-5.) )  ( Quadrato 10. ) 
let out9 = sommaArea  ( Rettangolo(2., 5.) ) ( Quadrato -10. )
let out10 =  sommaArea (Triangolo(10.,5.) ) ( Triangolo(3.5,5.) )

// ----------------------------------------------------------------------------

let rec sommaAreaList figs =
    match figs with
    | [] -> 0.0
    | fig :: other_figs -> 
        if well_formed fig 
        then area fig + sommaAreaList other_figs 
        else sommaAreaList other_figs

let ret = Rettangolo (5.0, 6.0)
let quad = Quadrato 2.0
let tr = Triangolo (2.0, -2.0)

let figs1 = [tr]
let s1 = sommaAreaList figs1

let figs2 = [ret; tr; quad; tr; ret; quad] 
let s2 = sommaAreaList figs2