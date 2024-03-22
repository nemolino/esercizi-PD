# Blocco 04 - Esercizi sulle liste

## Esercizio 1

Definire la funzione ricorsiva

`rmEven : int list -> int list`

che cancella da una lista di interi tutti i numeri pari.

Non vanno usate le funzioni su liste definite in F#. 

#### Esempi:

    rmEven [-10..10] ;;
    // val it: int list = [-9; -7; -5; -3; -1; 1; 3; 5; 7; 9]

    rmEven [2; 5; 5; 6; 6; 87; 6; 100; 2] ;;
    // val it: int list =  [5; 5; 87]

## Esercizio 2

Definire la funzione ricorsiva

`rmOddPos :  a' list -> 'a list`

che cancella tutti gli elementi di una lista in posizione dispari;
il primo elemento della lista ha posizione 0.

Non vanno usate le funzioni su liste definite in F#. 

#### Esempi:

    rmOddPos ['a'..'z'] ;;
    // val it : char list = ['a'; 'c'; 'e'; 'g'; 'i'; 'k'; 'm'; 'o'; 'q'; 's'; 'u'; 'w'; 'y']

    rmOddPos ["zero" ; "uno" ; "due" ; "tre" ; "quattro"] ;;
    // val it : string list = ["zero"; "due" ; "quattro"]

#### Suggerimento:

Distinguere con un opportuno pattern matching i casi in cui la lista passata come argomento abbia zero, uno, almeno due  elementi.

## Esercizio 3

Definire la funzione 

`split : 'a list -> 'a list * 'a list`

che, data una lista, costruisce la coppia di liste 
degli elementi in posizione pari e in posizione dispari.

Non vanno usate le funzioni su liste definite in F#. 

#### Esempi:

    split [0 .. 9] ;;
    // val it : int list * int list = ([0; 2; 4; 6; 8], [1; 3; 5; 7; 9])

    split ["ciao"] ;;
    // val it : string list * string list = (["ciao"], [])

    split ["ciao" ; "ciao!!!"] ;;  
    // val it : string list * string list = (["ciao"], ["ciao!!!"])

    split [ 'a' .. 'k'] ;;
    // val it : char list * char list = (['a'; 'c'; 'e'; 'g'; 'i'; 'k'], ['b'; 'd'; 'f'; 'h'; 'j'])

#### Suggerimento:

Usare uno schema di pattern matching simile a quello dell'esercizio precedente.

## Esercizio 4

Definire la funzione ricorsiva

`val swap: 'a list -> 'a list`

che scambia gli elementi di una lista a due a due; se la lista ha lunghezza dispari, l'ultimo elemento non cambia.

Non vanno usate le funzioni su liste definite in F#. 

#### Esempi:

    swap [1 .. 6] ;;
    // val it: int list = [2; 1; 4; 3; 6; 5]

    swap [1 .. 7] ;;
    // val it: int list = [2; 1; 4; 3; 6; 5; 7]

    swap ['a'; 'b'; 'c'] ;;         
    // val it: char list = ['b'; 'a'; 'c']

## Esercizio 5

Definire la funzione ricorsiva 

`cmpLength : cmpLength : 'a list -> 'b list -> int`

che, date due liste xs e ys, confronta le lunghezza (length) delle liste e restituisce:

- -1    se  length(xs) < length(ys)
- 0    se  length(xs) = length(ys)
- 1    se  length(xs) > length(ys)

Non vanno usate le funzioni su liste definite in F#. 

#### Esempi:

    cmpLength  [1..10] ['a'..'z'] ;;  
    // val it: int = -1

    cmpLength  [1..26] ['a'..'z'] ;;  
    // val it: int = 0

    cmpLength  ['a';'b';'c'] ["e";"f"] ;; 
    // val it: int = 1

#### Suggerimento:

Definire un opportuno pattern matching sulla coppia (ls0, ls1)

## Esercizio 6

Definire la funzione ricorsiva

`remove : 'a -> 'a list -> 'a list when 'a : equality`

che dato un elemento x e una lista ys, restituisce la lista ottenuta da ys eliminando tutte le occorrenze di x.

Non vanno usate le funzioni su liste definite in F#. 

#### Esempi:

    remove 2 [0..10] ;;
    // val it : int list = [0; 1; 3; 4; 5; 6; 7; 8; 9; 10]

    remove "uva" ["mele";"uva";"pere";"uva";"banane";"uva"] ;;
    // val it : string list = ["mele"; "pere"; "banane"]

    remove 11 [0..10] ;; 
    // val it : int list = [0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10]


Usando remove (e non le funzioni F#), definire la funzione ricorsiva

`removeDup : 'a list -> 'a list when 'a : equality` 

che rimuove tutti i duplicati in una lista.

Più precisamente, se un elemento x compare più volte, viene mantenuta solo la prima occorrenza.

#### Esempi:

    removeDup [1; 2; 1; 2; 3] ;;
    // val it : int list = [1; 2; 3]

    removeDup ["mele";"uva";"mele";"pere";"uva";"banane";"uva";"pere";"pere";"banane"] 
    // val it : string list = ["mele"; "uva"; "pere"; "banane"]

## Esercizio 7

Definire le funzioni  ricorsive

`downTo : int -> int list`

`upTo : int -> int list`

tali che
 
upTo n  = lista degli interi da 0 a n
    
downTo n  = lista degli interi da n a 0

In entrambe le funzioni si *assume* n >= 0.

Attenzione a non scrivere 'downto', che è una keyword di F#.

Non vanno usate le funzioni su liste definite in F#. 

#### Esempi:

    downTo 10 ;;
    // val it : int list = [10; 9; 8; 7; 6; 5; 4; 3; 2; 1; 0]

    upTo 10 ;;
    // val it : int list = [0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
