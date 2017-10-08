
let n = 600851475143L
let rec sieve i numbers =
    if i = List.length numbers then numbers
    else
        let p = List.nth numbers i
        // Take out all multiples of i from the list and continue
        sieve (i+1) (List.filter (fun n -> n <= p || n % p <> 0) numbers)

let primes = sieve 0 [2..100000]

let result = List.max (List.filter (fun p -> n % (int64 p) = 0L) primes)