// En el código siguiente se muestra una función recursiva que calcula el númerode Fibonacci n.
module recursividad = 
    let rec fib n =
        if n <= 2 then 1
        else fib (n - 1) + fib (n - 2)
//Funciones mutuamente recursivas
//A veces,las funciones son mutuamente recursivas, lo que significa que las llamadas forman un círculo, donde una función llama a otra que, a su vez, llama a la primera, con cualquier número de llamadas entre. Debe definir estas funciones juntas en un let enlace, utilizando la and palabra clave para vincularlas.
let rec Par x = 
    if x = 0 then true 
    else Impar (x-1) 
and Impar x = 
    if x = 0 then false 
    else Par (x-1)