module CreationSequence

let integers  = {1..1000}

let integersCom = seq {for i in 1..1000 do yield i}
let integerComTwo = seq {for i in 1..1000 -> i}

let integersModule = Seq.init 1000 (fun i -> i+1)
let integersModuleTwo = Seq.initInfinite (fun i -> i+1)


