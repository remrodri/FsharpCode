module TuberiasYComposicion =
    /// un valor al cuadrado
    let cuadrado x = x * x
    /// suma un a un valor
    let suma1 x = x + 1
    /// testear si un valor es impar por el modulo.
    let esPar x = x % 2 <> 0
    /// una lista de 5 numeros
    let numeros = [ 1; 2; 3; 4; 5 ]
    /// Dada una lista de números enteros, filtra los números pares,
    /// al cuadrado los resultados, y añade 1 a cada uno de ellos
    let valorAlCuadradoYSumado1 valores = 
        let pares = List.filter esPar valores
        let cuadrados = List.map cuadrado pares
        let resultado = List.map suma1 cuadrados
        resultado
    printfn "procesamiento de %A a travez de 'valorAlCuadradoYSumado1' produce: %A" numeros (valorAlCuadradoYSumado1 numeros)
    /// Una forma más corta de escribir "valorAlCuadradoYSumado1" es anidar cada sub-resultado en la función que se llama a sí mismo.
    /// Esto hace que la función sea mucho más corta, pero es difícil ver el orden en que se procesan los datos.
    let valorAlCuadradoYSumado1Anidado valores = 
        List.map suma1 (List.map cuadrado (List.filter esPar valores))
    printfn "procesar %A a travez de 'valorAlCuadradoYSumado1Anidado' produce: %A" numeros (valorAlCuadradoYSumado1Anidado numeros)
    /// Una forma preferida de escribir 'valorAlCuadradoYSumado1' es usar operadores de tuberías F#.
    /// This allows you to avoid creating intermediate resultados, but is much more readable
    /// than nesting function calls like 'valorAlCuadradoYSumado1Anidado'
    let valorAlCuadradoYSumado1Tuberia valores =
        valores
        |> List.filter esPar
        |> List.map cuadrado
        |> List.map suma1
    printfn "processing %A through 'valorAlCuadradoYSumado1Tuberia' produces: %A" numeros (valorAlCuadradoYSumado1Tuberia numeros)
    /// Puedes acortar "squareOddValuesAndAddOneTuberia" moviendo la segunda llamada de "List.map" a la primera, usando una función Lambda.
    /// Obsérvese que las tuberías también se utilizan dentro de la función lambda.  Los operadores de tuberías F# también pueden ser utilizados para valores individuales.  Esto los hace muy poderosos para el procesamiento de datos.
    let valorAlCuadradoYSumado1TuberiaAcortada valores =
        valores
        |> List.filter esPar
        |> List.map(fun x -> x |> cuadrado |> suma1)
    printfn "procesar %A a travez de 'valorAlCuadradoYSumado1ShorterPipeline' produces: %A" numeros (valorAlCuadradoYSumado1TuberiaAcortada numeros)