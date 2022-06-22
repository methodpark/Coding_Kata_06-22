namespace FSharpKata

module FizzBuzz =
    let translate n =
        match n with
            | _ when n % 15 = 0 -> "FizzBuzz"
            | _ when n %  3 = 0 -> "Fizz"
            | _ when n %  5 = 0 -> "Buzz"
            | n                 -> string n

    let getSequence n =
        seq { for i in 1 .. n do translate i }