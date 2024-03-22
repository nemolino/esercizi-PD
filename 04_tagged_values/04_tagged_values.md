# Blocco 04 - Esercizi sui tagged values

## Esercizio 1

Riconsideriamo le seguenti definizioni viste a lezione:

    type figura = 
        | Rettangolo of  float * float
        | Quadrato   of  float
        | Triangolo  of  float * float

    let area fig =
        match fig with
        | Rettangolo(b,h) -> b * h     
        | Quadrato l      -> l * l  
        | Triangolo(b,h)  -> ( b * h ) / 2.0 

Una figura è well_formed (ben definita) se nessuna delle sue dimensioni è negativa.

Per riconoscere se una figura è ben definita, si può usare la funzione

    let well_formed fig =
        match fig with
        | Rettangolo(b,h) | Triangolo(b,h) -> b >= 0 && h >= 0     
        | Quadrato l -> l >= 0  

### 1) 

Definire la funzione `areaOpt` che calcola l'area di una figura fig, se fig è ben definita. 

La funzione `areaOpt` ha tipo

`areaOpt : figura -> float option`

e restituisce:

- None se fig non è ben definita 
- Some a se fig è ben definita e l'area di fig è a (un float).

#### Esempi:

    areaOpt ( Rettangolo(2.0, 3.0) ) ;;
    // val it : float option = Some 6.0

    areaOpt ( Rettangolo(2.0, -3.0) ) ;;
    // val it : float option = None

    areaOpt ( Triangolo(2.5, 3.6) ) ;;
    // val it : float option = Some 4.5

    areaOpt ( Triangolo(-2.5, 3.6) ) ;;
    // val it : float option = None


### 2) 

Definire la funzione

`printArea : figura -> string`

che calcola l'area di una figura e restituisce una stringa col risultato.

Per la conversione da float a string,  usare la funzione `string`.

Se l'area non è definita, va restituita un opportuno messaggio come da esempi sotto

#### Esempi:

    printArea ( Quadrato 10.0 ) ;; 
    // val it : string = "area: 100"

    printArea ( Quadrato -10.0 ) ;;
    // val it : string = "la figura non è ben definita"


### 3) 

Definire la funzione

`sommaArea :  figura -> figura -> float option`

che, date due figure fig1 e fig2, restituisce la somma delle aree delle due figure, se la somma è definita (ossia, se entrambe le figure fig1 e fig2 sono ben definite).

Il risultato deve essere un option type.

Per calcolare l'area, usare la funzione `areaOpt` definita sopra.

#### Esempi: 

    sommaArea ( Rettangolo(2.,5.) )  ( Quadrato 10. ) ;;
    // val it : float option = Some 110.0

    sommaArea ( Rettangolo(2.,-5.) )  ( Quadrato 10. ) ;;
    // val it : float option = None

    sommaArea ( Rettangolo(2., 5.) ) ( Quadrato -10. ) ;;
    // val it : float option = None

    sommaArea ( (Triangolo(10.,5.) ) ( Triangolo(3.5,5.) ) ;;
    // val it  : float option = Some 33.75

### 4) 

Definire la funzione

`sommaAreaList : figura list -> float`

che, data una lista figs di figure, calcola la somma delle aree delle figure ben definite contenute in figs.

Se la lista figs non contiene figure ben definite, la somma vale zero.

#### Esempi:

    let ret = Rettangolo (5.0, 6.0)
    let quad =  Quadrato 2.0
    let tr = Triangolo (2.0, -2.0)

    let figs1 = [tr]   // la lista non contiene figure ben definite

    let s1 = sommaAreaList figs1
    // val s1 : float = 0.0

    let figs2 = [ret; tr; quad; tr; ret; quad]

    let s2 = sommaAreaList figs2
    // val s2 : float = 68.0
