// Los datos del grupo con los registros
type RetiroExitoso = {
    Monto: decimal
    Balance: decimal
}

type Retirofallido = {
    Monto: decimal
    Balance: decimal
    EstaSobregirado: bool
}

// Usar uniones discriminadas para representar datos de 1 o más formas
type ResultadoDelRetiro =
    | Exito of RetiroExitoso
    | FondosInsuficientes of Retirofallido
    | TarjetaExpirada of System.DateTime
    | FalloNoRevelado

/// Este ejemplo muestra cómo definir un nuevo tipo de registro.  
    type Contacto = 
        { Nombre     : string
          Telefono    : string
          Verificado : bool }
    /// Este ejemplo muestra cómo instanciar un tipo registro.
    let contacto1 = 
        { Nombre = "Alf" 
          Telefono = "(206) 555-0157" 
          Verificado = false }
    /// También puedes hacer esto en la misma línea con el separador ';'.
    let contactOnSameLine = { Nombre = "Alf"; Telefono = "(206) 555-0157"; Verificado = false }
    /// Este ejemplo muestra cómo usar "copiar y actualizar" en los valores
    /// del registro. Crea un nuevo valor de registro que es una copia de 
    /// contacto1, pero tiene valores diferentes para los campos "Telefono" y 
    /// "Verificado".
    let contacto2 = 
        { contacto1 with 
            Telefono = "(206) 555-0112"
            Verificado = true }
    /// Este ejemplo muestra cómo escribir una función que procesa un valor de un registro.
    /// Convierte un objeto 'Contacto' en un cadena.
    let mostrarContacto (c: Contacto) = 
        c.Nombre + " Telefono: " + c.Telefono + (if not c.Verificado then " (noVerificado)" else "")
    printfn "Contacto de Alf: %s" (mostrarContacto contacto1)
    /// Este es un ejemplo de un registro con un miembro.
    type ContactoAlternate =
        { Nombre     : string
          Telefono    : string
          Address  : string
          Verificado : bool }
        /// Los miembros pueden implementar miembros orientados a objetos.
        member this.PrintedContacto =
            this.Nombre + " Telefono: " + this.Telefono + (if not this.Verificado then " (noVerificado)" else "") + this.Address
    let contactAlternate = 
        { Nombre = "Alf" 
          Telefono = "(206) 555-0157" 
          Verificado = false 
          Address = "111 Alf Street" }
    // Se accede a los miembros a través del operador '.' en un tipo instanciado.
    printfn "Contacto alterno de Alf es %s" contactAlternate.PrintedContacto