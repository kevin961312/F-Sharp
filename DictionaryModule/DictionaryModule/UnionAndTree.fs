module UnionAndTree

open System

type Description =
    { Name : string;
      PartNumber : string
      Cost : decimal option
    }

type Part =
    | Item of Description
    | Repeat of  Part * int
    | Compound of Description * Part list

let pad = Item { Name = "Brake Pad"; PartNumber = "B12345"; Cost = Some 15.90M}