#r "nuget:FsCheck";;
open FsCheck;

// -----------------------------------------------------------------------------

//  1.1 remove even numbers from int list
//  rmEven : int list -> int list
let rmEven xs =
    xs |> List.filter (fun x -> x % 2 = 1)


//  + if I remove even numbers from a list, what's left are odds
let prop_onlyOdds (xs:int list) =
    xs |> rmEven |> List.forall (fun x -> x % 2 = 1) ;;

do Check.Quick prop_onlyOdds

// -----------------------------------------------------------------------------

//  1.2 remove all elements in odd position from a list 
//  considering the first element an even position.
//  rmOdd : rmOdd : 'a list -> 'a list

let rec rmOdd xs =
    match xs with 
    | ([] | [_]) ->  xs
    | y :: _ :: ys -> y :: rmOdd ys


//  + if I remove the odd positions, 
//    the length of the resulting list is more or less halved
let prop_halvedLength (xs:int list) =
    let len_before = xs |> List.length
    let len_after = xs |> rmOdd |> List.length
    len_after = len_before / 2 || len_after = len_before / 2 + 1

do Check.Quick prop_halvedLength

//  the function do not add "new" elements,
//  that is the underlying resulting set is a subset of the starting one

let prop_noNewElements (xs:int list) =
    Set.isSubset (xs |> rmOdd |> Set.ofList) (xs |> Set.ofList)

do Check.Quick prop_noNewElements

// -----------------------------------------------------------------------------

//  1.3 split a list into two pair of lists consisting of the even and odd positions
//  split : 'a list -> 'a list * 'a list

let rec split xs =
    match xs with
    | [] -> ([],[])
    | [y] -> ([y],[])
    | y1 :: y2 :: ys -> 
        let y_evens, y_odds = split ys
        (y1 :: y_evens, y2 :: y_odds)


let rec merge lists =
    match lists with
    | ([],[]) -> []
    | ([x],[]) -> [x]
    | (x::x_other, y::y_other) -> x :: y :: merge (x_other, y_other)
    | _ -> failwith "should not happen"


// show merge (split xs) = xs
let prop_mergeInverse (xs:int list) =
    xs |> split |> merge = xs

do Check.Quick prop_mergeInverse


//  the function do not add "new" elements,
//  that is the underlying resulting set is a subset of the starting one
let prop_noNewElements2 (xs:int list) =
    (xs |> split |> merge |> Set.ofList) = (xs |> Set.ofList)

do Check.Quick prop_noNewElements2


// check than |odds| <= |evens|
let prop_lengthsCheck (xs:int list) =
    let y_evens, y_odds = split xs
    List.length y_evens = List.length y_odds || 
    List.length y_evens = List.length y_odds + 1

do Check.Quick prop_lengthsCheck

// -----------------------------------------------------------------------------

// assumo n >= 0
let rec downTo0 n =
    match n with
    | 0 -> [0]
    | n -> n :: downTo0 (n-1)

//  + check that your def of downto0 corresponds to [n .. -1 .. 0]
//  (Hint: exclude the case for n negative)
let prop_downTo0Check n =
    n >= 0 
    ==> 
    lazy (downTo0 n = [n .. -1 .. 0])

do Check.Quick prop_downTo0Check