// Un bucle for... to que utiliza funciones como las expresiones de inicio y fin.
let inicio x y = x - 2*y
let fin x y = x + 2*y

let funcion x y =
  for i = (inicio x y) to (fin x y) do
     printf "%d " i
  printfn ""

funcion 10 4