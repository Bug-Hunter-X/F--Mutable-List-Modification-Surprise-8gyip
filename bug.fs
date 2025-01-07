let mutable x = 10

let addOne x = 
    x <- x + 1
    x

let result = addOne x
printf "%d %d" x result //This will print 11 11, as expected

let mutable y = [1;2;3]

let addOneToFirst y = 
    y.[0] <- y.[0] + 1
    y

let result2 = addOneToFirst y
printf "%A %A" y result2 //This will print [2;2;3] [2;2;3], which might be unexpected if you're not aware of how mutable lists work in F#.