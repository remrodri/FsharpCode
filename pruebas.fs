module UnionesDiscriminadas = 
    /// Lo siguiente representa el Conjunto de un juego de cartas.
    type Conjunto = 
        | Corazones 
        | Treboles 
        | Diamantes 
        | Espadas
    /// Una Unión Discriminada también puede ser usada para representar el rango de una carta de juego.
    type Rango = 
        /// Representa el Rango de las cartas 2 .. 10
        | Value of int
        | As
        | Rey
        | Reyna
        | Jack
        /// Las Uniones Discriminadas también pueden implementar miembros orientado a objetos.
        static member GetTodosRangos() = 
            [ yield As
              for i in 2 .. 10 do yield Value i
              yield Jack
              yield Reyna
              yield Rey ]
                                   
    /// Este es un tipo de registro que combina un Conjunto y un Rango.
    /// Es común utilizar tanto los registros como las uniones discriminadas al representar los datos.
    type Carta = { Conjunto: Conjunto; Rango: Rango }
              
    /// Esto calcula una lista que representa a todas las Cartas de la baraja.
    let barajaCompleta = 
        [ for conjunto in [ Corazones; Diamantes; Treboles; Espadas] do
              for rango in Rango.GetTodosRangos()do 
                  yield { Conjunto=conjunto; Rango=rango }  ]
    /// Este ejemplo convierte un objeto "Carta" en una cadena.
    let mostrarCarta (c: Carta) = 
        let RangoString = 
            match c.Rango with 
            | As -> "As"
            | Rey -> "Rey"
            | Reyna -> "Reyna"
            | Jack -> "Jack"
            | Value n -> string n
        let ConjuntoString = 
            match c.Conjunto with 
            | Treboles -> "Treboles"
            | Diamantes -> "Diamantes"
            | Espadas--> "Espadas"
            | Corazones -> "Corazones"
        RangoString  + " de " + ConjuntoString

    /// Este ejemplo imprime todas las Cartas en una baraja.
    let imprimitTodasLasCartas() = 
        for carta in barajaCompleta do 
            printfn "%s" (mostrarCarta carta)