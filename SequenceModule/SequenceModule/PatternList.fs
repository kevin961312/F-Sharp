module PatternList

type SimpleStack <'T>() =
    let mutable _stack : List<'T> = []
    member this.Push value =
      _stack <- value :: _stack
    member this.Pop value =
        if _stack.IsEmpty then
            failwith "Empty Stack"
        else
            let result::remainder = _stack
            _stack <- remainder
            result

