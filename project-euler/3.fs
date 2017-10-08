
let n = 600851475143L
let rec sieve i max numbers =
    // Take out all multiples of i from the list
    let filteredNumbers = List.filter (fun n -> n <= i || n % i <> 0) numbers
    if i = max then filteredNumbers
    else sieve (i+1) max filteredNumbers

let primes = sieve 2 10000 [2..10000]

let result = List.max (List.filter (fun p -> n % (int64 p) = 0L) primes)