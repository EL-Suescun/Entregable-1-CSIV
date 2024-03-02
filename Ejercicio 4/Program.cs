/* Implementar un programa que simule un sistema de incio de sesiòn. El usuario debe ingresar su nombre de usuario y contraseña. Si el nombre de usuario y la contraseña coincide con los valores predefinidos, el usuario puede acceder al sistema. Si no, se le debe informar que el nombre de usuario o contrañse son incorrectos y se debe permitir intentarlo nuevamente, hasta un máximo de 3 intentos.  

Instrucciones: 
° Define un nombre de usuario y una contraseña predefinidos en tu código. 
° Solicita al usuario que ingrese su nombre de usuario y contraseña.
° Compara los valores ingresados por el usuario con los valores predefinidos.
° Si el nombre de usuario y la contraseña coinciden con los valores predefinidos muestra un mensaje que diga "Acceso concedido" y finaliza el programa 
° Si no coinciden, informa al usuario que el nombre de usuario o la contraseña son incorrectos y reduce en uno el contador de intentos
° Si el usuario agota sus 3 intentos, muestra un mensaje que diga "Acceso denegado" y finaliza el programa 
° Asegúrate de proporcionar retroalimentación al usuario después de cada intento, indica cuántos intentos quedan*/

string usuario_predefinido = "Psicologia123";

string contraseña_predefinida = "123contraseña321";

string usuario_ingresado = "";

Console.Write("Ingrese su contraseña: ");
string contraseña_ingresada = Console.ReadLine();

int intentos = 0;

while ((usuario_ingresado != usuario_predefinido && contraseña_ingresada != contraseña_predefinida) || intentos<3){
    Console.Write("Ingrese su usuario: ");
    usuario_ingresado = Console.ReadLine();
    if(usuario_ingresado != usuario_predefinido)
}



