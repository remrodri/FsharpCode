module Tuplas =
    /// una tupla simple de integers.
    let tupla1 = (1, 2, 3)
    /// a continuacion se crea una función que intercambia el orden de dos valores en una tupla. 
    /// la inferencia de tipos de F# generalizará automáticamente la función para tener un tipo genérico, 
    /// lo que significa que funcionará con cualquier tipo
    let intercambiarElems (a, b) = (b, a)
    printfn "El resultado del intercambio (1, 2) es %A" (intercambiarElems (1,2))
    /// una tupla que consiste de un entero, cadena y double,
    let tupla2 = (1, "fred", 3.1415)
    printfn "tupla1: %A\ttupla2: %A" tupla1 tupla2