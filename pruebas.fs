// Un bucle for... to que utiliza funciones como las expresiones de inicio y fin.
let inicio x y = x - 2*y
let fin x y = x + 2*y

let funcion x y =
  for i = (inicio x y) to (fin x y) do
     printf "%d " i
  printfn ""

funcion 10 4

//Bucles: expresión for...in
//La for...in expresión se puede comparar con la for each instrucción en otros lenguajes .net porque se usa para recorrer los valores de una colección Enumerable. Sin embargo for...in , también admite la coincidencia de patrones en la colección en lugar de simplemente la iteración en toda la colección.