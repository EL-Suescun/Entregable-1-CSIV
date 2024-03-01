/* Crear un programa que detemine si un número ingresado por el usuario es un número "Especial". Un número es "especial" si cumple con los siguientes criterios: 
1. Es divisible entre 5
2. No es divisible entre 2 ni 3. */

Console.Write("Ingrese un numero entero: ");
int numero_especial = int.Parse(Console.ReadLine());

if (numero_especial%5 == 0 && numero_especial%2 != 0 && numero_especial%3 != 0){
    Console.Write($"El numero {numero_especial}, si es un numero especial");
}else{
    Console.Write($"El numero {numero_especial}, no es un numero especial");
}