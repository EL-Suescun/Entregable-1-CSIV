/* El programa tomará la edad del usuario y determinará cuántos días y semanas han transcurrido desde el año actual. */
/* Ingresar edad */
Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());

String fecha = DateTime.Now.AddYears(0).ToString("yyyy");
int fechaFinal = int.Parse(fecha);

/* FechaInicial */
int fechaInicial = fechaFinal-edad;

/* Determinar cantidad de bisiestos */
int cntidadBisiestos=0;
for (int i = fechaInicial; i <= fechaFinal; i++)
{
    if (i%4==0)
    {
       cntidadBisiestos+=1;
    }
}

Console.WriteLine("bisiestos: " + cntidadBisiestos);

/* determinar dias y semanas */
int cantidadNoBisiestos = edad-cntidadBisiestos;
int dias = (cantidadNoBisiestos*365)+(cntidadBisiestos*366);
int semanas = dias/7;

/* output */
Console.WriteLine("dias transcurridos: "+dias);
Console.WriteLine("semanas transcurridas: "+semanas);