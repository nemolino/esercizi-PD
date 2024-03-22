# Blocco 08 - Esercizio sul PBT

## Esercizio

Remember your functions:

1.  remove even numbers from int list

    `rmEven : int list -> int list`
    
2.  remove all elements in odd **position** from a list considering the first element an even position.

    `rmOdd : rmOdd : 'a list -> 'a list`
    
3.  split a list into two pair of lists consisting of the even and odd positions
    
    `split : 'a list -> 'a list * 'a list`
    

Validate them with FsCheck writing the following properties

- if I remove even numbers from a list, what's left are odds

- if I remove the odd positions, the length of the resulting list is
  more or less halved

- in cases 2. and 3. , the functions do not add "new" elements, that is the underlying resulting set is a subset of the starting one
    - Hint for 3. : define the inverse function of `split`, say `merge` and
    show smerge (split xs) = xs

- check that your def of `downTo0` corresponds to [n .. -1 .. 0]
    - Hint : exclude the case for n negative


You can use the function in the List library (example List.length) and
 the Set library for example Set.isSubset and Set.ofList