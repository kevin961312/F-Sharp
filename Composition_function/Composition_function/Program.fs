let minusone  x = x-1
let timestwo = (*) 2

minusone 1
timestwo 8

timestwo(minusone 9)

let minusoneThenTimeTwo = timestwo << minusone
minusoneThenTimeTwo 9
(timestwo << minusone ) 9
(timestwo << minusone ) <|9

minusone(timestwo 9)
let timestwoThenMinusOne = timestwo >> minusone
timestwoThenMinusOne 9
