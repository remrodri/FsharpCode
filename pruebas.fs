module Arrays =
    let array1 = [| |]
    let array2 = [| "hello"; "world"; "and"; "hello"; "world"; "again" |]
    let array3 = [| 1 .. 1000 |]
    /// Esta es un Array que contiene sólo las palabras "hola" y "mundo".
    let array4 = 
        [| for word in array2 do
               if word.Contains("l") then 
                   yield word |]
    /// Puedes hacer un bucle sobre los arreglos y las listas usando los bucles 'for'.
    for word in array4 do 
        printfn "word: %s" word
    // Puedes modificar el contenido de un elemento de la matriz usando el operador de asignación de flecha izquierda.
    printfn "%s" array2.[1]
    array2.[1] <- "WORLD!"
    printfn "%s" array2.[1]
    /// Puedes transformar matrices usando 'Array.map' y otras operaciones de programación funcional.
    /// A continuación se calcula la suma de las longitudes de las palabras que comienzan con "h".
    let sumOfLengthsOfWords = 
        array2
        |> Array.filter (fun x -> x.StartsWith "h")
        |> Array.sumBy (fun x -> x.Length)
    printfn "La suma de las longitudes de las palabras en la matriz 2 es: %d" sumOfLengthsOfWords 