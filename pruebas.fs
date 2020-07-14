module FuncionesBasicas = 
    /// Usa 'let' para definir una funcion. Este acepta un argumento entero y devuelve un entero. 
    /// Los paréntesis son opcionales para los argumentos de las funciones, excepto cuando se utiliza una anotación explícita.
    let ejemploDeFuncion1 x = x*x + 3
    /// Aplicar la función, nombrando el resultado de retorno de la función con 'let'. 
    /// El tipo de variable se infiere del tipo de retorno de la función.
    let resultado1 = ejemploDeFuncion1 4573  

    // usa '%d' para imprimir el resultado como un entero.
    // Si "resultado1" no fuera del tipo "int", entonces la línea fallaría en la compilación.
    printfn "El resultado del integer 4573 al cuadrado y sumado 3 es  %d" resultado1

    /// When needed, annotate the type of a parameter name using '(argument:type)'.  Parentheses are required.
    let sampleFunction2 (x:int) = 2*x*x - x/5 + 3

    let result2 = sampleFunction2 (7 + 4)
    printfn "The result of applying the 2nd sample function to (7 + 4) is %d" result2

    /// Conditionals use if/then/elif/else.
    ///
    /// Note that F# uses white space indentation-aware syntax, similar to languages like Python.
    let sampleFunction3 x = 
        if x < 100.0 then 
            2.0*x*x - x/5.0 + 3.0
        else 
            2.0*x*x + x/5.0 - 37.0

    let result3 = sampleFunction3 (6.5 + 4.5)

    // This line uses '%f' to print the result as a float.  As with '%d' above, this is type-safe.
    printfn "The result of applying the 3rd sample function to (6.5 + 4.5) is %f" result3