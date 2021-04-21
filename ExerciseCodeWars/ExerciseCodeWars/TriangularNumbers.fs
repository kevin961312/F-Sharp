module TriangularNumbers

let sumOfN (n : int) : int list =
    [for i in 0 .. abs(n) -> if n<0 then -i*(i+1)/2 else i*(i+1)/2]

sumOfN -6