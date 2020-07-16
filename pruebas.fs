// Este ejemplo utiliza patrones que tienen cuando los guardias.
let detectarValor punto objetivo =
    match punto with
    | (a, b) when a = objetivo && b = objetivo -> printfn "Ambos valores coinciden con el objetivo %d." objetivo
    | (a, b) when a = objetivo -> printfn "El primer valor coincide con el objetivo (%d, %d)" objetivo b
    | (a, b) when b = objetivo -> printfn "El segundo valor coincidió con el objetivo (%d, %d)" a objetivo
    | _ -> printfn "Ninguno de los dos valores coincide con el objetivo."
detectarValor (0, 0) 0
detectarValor (1, 0) 0
detectarValor (0, 10) 0
detectarValor (10, 15) 0