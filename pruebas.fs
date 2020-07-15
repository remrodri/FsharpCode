// Expresiones condicionales:if...then...else
// A diferencia de otros lenguajes, if...then...else la construcción es una expresión, no una instrucción. Esto significa que genera un valor, que es el valor de la última expresión de la bifurcación que se ejecuta
let test x y =
  if x = y then "igual a"
  elif x < y then "es menor que"
  else "es mayor que"

printfn "%d %s %d." 10 (test 10 20) 20

printfn "What is your name? "
let nameString = System.Console.ReadLine()

printfn "What is your age? "
let ageString = System.Console.ReadLine()
let age = System.Int32.Parse(ageString)

if age < 10
then printfn "You are only %d years old and already learning F#? Wow!" age