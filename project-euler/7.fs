
let rec sieve i numbers =
    if i = List.length numbers then numbers
    else
        let p = List.nth numbers i
        // Take out all multiples of i from the list and continue
        sieve (i+1) (List.filter (fun n -> n <= p || n % p <> 0) numbers)

let primes = sieve 0 [2..150000]

let result = List.nth primes 10001