/* Crear una calculadora que maneje fracciones. El usuario ingresará dos 
fraciones y un operador. La calculadora deberá realizar la operación. Debes 
manejar sumas, restas, multiplicaciones y divisiones. Si el usuario intenta
dividir entre deberás mostrar un mensaje de error */

Console.Write("Ingrese el primer numero: ");
float fraccion_1 = float.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
float fraccion_2 = float.Parse(Console.ReadLine());

Console.Write("CALCULADORA \nEscoge una funcion: \n"+
"1. Suma\n"+
"2. Resta\n"+
"3. Multiplicacion\n"+
"4. Division\n");
int operacion = int.Parse(Console.ReadLine());


switch (operacion)
{
    case 1:
        float suma = fraccion_1 + fraccion_2;
        Console.Write($"La suma de {fraccion_1} y {fraccion_2}, es: {suma}");
        break;
    case 2:
        
        break;
    case 3:
        
        break;
    case 4:
        
        break;    
    default:
        Console.WriteLine("Opcion no valída.");
        break;
}
