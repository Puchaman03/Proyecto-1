using System.Diagnostics; // no se que es esto, simplemente aparecio 

// Declaracion de las variables

int op = 0;// variable para el operador del menu; no se asusten puse 3 para cuando este haciendo pruebas no tenga que poner 10 estudiantes, luego se cambia
string[] Cedulas = new string[3];//arreglo de las cedulas
string[] Nombres = new string[3]; ;//arreglo de los nombres 
int[] promedio = new int[3]; ;//arreglo de los promedios
string[] Condicion = new string[3]; ;//arreglo de las condiciones de los estudiantes


while (op < 7) // con este while hare funcionar el menu, hasta que el usuario ponga una numero = o > que 7;
{
    op = Menu(op);// llamo ala funcion Menu, y declaro que el valor de op dentro del while sera decido por la funcion
    switch (op)
    {
        case 2://incluir estudiantes, esta parte la tiene que hacer otro compañero pero la tenia que hacer para ver si mi parte funciona
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ponga la cedula del estudiante");
                Cedulas[i] = Console.ReadLine();
                Console.WriteLine("Ponga el nombre del estudiante");
                Nombres[i] = Console.ReadLine();
                Console.WriteLine("Ponga el Promedio del estudiante");
                promedio[i] = int.Parse(Console.ReadLine());
                if (promedio[i] >= 70 )
                {
                    Condicion[i] = "Aprobado";
                }
                else
                {
                    Condicion[i] = "Reprobado";
                }
                Console.WriteLine();

            }

            break;

        case 3:
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Cedula: {Cedulas[i]}");
                Console.WriteLine($"Nombre: {Nombres[i]}");
                Console.WriteLine($"Promedio: {promedio[i]}");
                Console.WriteLine($"Condicion: {Condicion[i]}");
                Console.WriteLine();
            }
            break;

        case 4:

            break;
    }




}

Console.WriteLine(@" 
Gracias");// un detalle final nada mas 

static int Menu(int op) // Esta una funcion, que crea el menu, se que la compañera se encargaba de esta parte pero es que ocupa un menu para hacer mi parte 
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;// esto es para darle color nada mas 

    Console.WriteLine("""
        **********Bienvenido al Sistema de Registro Estudiantil de la Universidad Hispanoamerica**************

     -1 Inicializar Vectores

     -2 Inclir Estudiantes

     -3 Consultar Estudiantes

     -4 Modificar Estudiantes

     -5 Eliminar Estudiantes

     -6 Submenú Reportes

     -7 Salir
     """);

    try//pongo try para que si el usuario pone algo que no sea un numero, o un numero negativo para evitando dar error 
    {
        op = int.Parse(Console.ReadLine()); // Aqui pido el operador

        if (op <=0)// por si el usuario pone numeros negativos
        {
            Console.WriteLine(@"
Porfavor astengase de poner numeros negativos o nulos
");
            op = 0;

        }
    }
    catch (FormatException)// por si el usurio pone algo que no sea numeros. el formatExceotion captura elementos que no sea del mismo tipo, por ejemplo op es init pero si se pone una letra cuando se solicita seria string por lo que el catch los dectecta 
    {
        Console.WriteLine("Digite una opcion válida.");
        Console.WriteLine();
        op = 0; // Reiniciar op si se produce un error de formato
    }

    return op;
}