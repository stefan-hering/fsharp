// Euler 1
let f = fun n -> n % 3 = 0 || n % 5 = 0

let result = [1..999] |> List.filter f |> List.sum