

let rec fibo n =
  match n with
    | 0 -> 1
    | 1 -> 1
    | _ -> fibo(n-1) + fibo(n-2)

let n = [for i in 1..32 -> fibo i] |> List.filter (fun i -> i%2 = 0) |> List.sum 