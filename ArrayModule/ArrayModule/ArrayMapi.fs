module ArrayMapi

let vowelPositions (str: string) =
    let Vowels = "aeiouAEIOU"
    str.ToCharArray()
    |> Array.mapi (fun i c -> if Vowels.Contains(c.ToString()) then
                                sprintf "Vowel at position %i %c" i c
                              else
                                "Some other character")

vowelPositions "Pluralsight"