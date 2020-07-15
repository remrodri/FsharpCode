/// Las unidades de medida son una forma de anotar los tipos numéricos primitivos de forma segura.
/// Puedes entonces realizar aritmética segura de tipos en estos valores.
module UnidadesDeMedida = 
    /// Primero, abre una colección de nombres de unidades comunes
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    /// Adefinir un nuevo tipo de unidad
    [<Measure>]
    type mile =
        /// Factor de conversión milla a metro.
        static member asMeter = 1609.34<meter/mile>
    /// Definir una constante consolidada/unificada
    let ejemploDeValor2 = 500.0<mile>
    /// Calcular la constante del sistema métrico
    let ejemploDeValor3 = ejemploDeValor2 * mile.asMeter   
    // Los valores que usan unidades de medida pueden ser usados como el tipo numérico primitivo para cosas como la impresión.
    printfn "Yo recorrere %f millas lo que seria %f metros" ejemploDeValor2 ejemploDeValor3