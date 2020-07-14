module inmutabilidad =
    /// ejemplo de inmutabilidad
    /// la segunda linea de codigo falla en la compilacion porque el "numero" es inmutable y esta ligado.
    /// Redefinir "numero" para que sea un valor diferente no esta permitido en F#.
    let numero = 2
    /// let numero = 3
    /// una union mutable a continuacion. esto es necesario para poder mutar el valor de "otro numero".
    let mutable otroNumero = 2
    printfn "otroNumero  es %d" otroNumero
    /// al mutar un valor, usa '<-' para asignar un nuevo valor.
    otroNumero <- otroNumero + 1
    printfn "otroNumero cambio para ser %d" otroNumero