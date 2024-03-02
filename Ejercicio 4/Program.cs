/* Implementar un programa que simule un sistema de incio de sesiòn. El usuario debe ingresar su nombre de usuario y contraseña. Si el nombre de usuario y la contraseña coincide con los valores predefinidos, el usuario puede acceder al sistema. Si no, se le debe informar que el nombre de usuario o contrañse son incorrectos y se debe permitir intentarlo nuevamente, hasta un máximo de 3 intentos.  

Instrucciones: 
° Define un nombre de usuario y una contraseña predefinidos en tu código. 
° Solicita al usuario que ingrese su nombre de usuario y contraseña.
° Compara los valores ingresados por el usuario con los valores predefinidos.
° Si el nombre de usuario y la contraseña coinciden con los valores predefinidos muestra un mensaje que diga "Acceso concedido" y finaliza el programa 
° Si no coinciden, informa al usuario que el nombre de usuario o la contraseña son incorrectos y reduce en uno el contador de intentos
° Si el usuario agota sus 3 intentos, muestra un mensaje que diga "Acceso denegado" y finaliza el programa 
° Asegúrate de proporcionar retroalimentación al usuario después de cada intento, indica cuántos intentos quedan*/

string usuario_predefinido = "sico";

string contraseña_predefinida = "1234";

string usuario_ingresado = "";

string contraseña_ingresada = "";

int intentos = 0;

bool validacion_usuario_contraseña = false;

while (validacion_usuario_contraseña == false && intentos<3){
    Console.Write("Ingrese su usuario: ");
    usuario_ingresado = Console.ReadLine();
    if(usuario_ingresado == usuario_predefinido){
        Console.Write("Ingrese su contraseña: ");
        contraseña_ingresada = Console.ReadLine();
        if(contraseña_ingresada == contraseña_predefinida){
            validacion_usuario_contraseña = true;
        }else{
            Console.Write("Contraseña no valida \n");
            intentos++;
            Console.Write("Numero de intentos disponibles: {3-intentos} \n");
        }
    }else{
        Console.Write("Usuario no valido \n");
        intentos++;
        Console.Write($"Numero de intentos disponibles: {3-intentos} \n");
    }
}

if(validacion_usuario_contraseña){
    Console.Write("Acceso concedido");
}else{
    Console.Write("Acceso denegado");
}



