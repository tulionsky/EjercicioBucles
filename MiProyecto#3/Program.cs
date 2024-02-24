//ENUNCIADO 1
//PRIMERO
//for (int i = 2; i <= 10; i=i+2)
//{
//    Console.WriteLine(i);
//}

//SEGUNDO
//int s=0;
//for (int i = 1; i <= 10; i++)
//{ 
//    s += i ;
//}
//Console.WriteLine("La suma es de: " + s);

//ENUNCIADO 2

//PRIMERO
//int n,s=0;
//do
//{
//    Console.WriteLine("Ingrese un numero entero positivo");
//    int.TryParse(Console.ReadLine(), out n);
//    if (n >= 0)
//    {
//        s += n;
//    }
//    while (n >= 0) ;

//    Console.WriteLine("La suma de los números ingresados es: " + s);
//}

//SEGUNDO

//int numero = 1;
//while (true)
//{
//    if (numero % 7 == 0 && numero % 11 == 0)
//    {
//        Console.WriteLine("El primer número entero positivo divisible entre 7 y 11 es: " + numero);
//        break;
//    }
//    numero++;
//}

//TERCER ENUNCIADO

//PRIMERO
//string contraseña;
//do
//{
//    Console.Write("Ingrese la contraseña: ");
//    contraseña = Console.ReadLine();

//    if (contraseña != "jutiapa")
//    {
//        Console.WriteLine("Contraseña incorrecta. Inténtelo nuevamente.");
//    }
//} while (contraseña != "jutiapa");

//Console.WriteLine("¡Contraseña correcta! Bienvenido.");

//SEGUNDO ENUNCIADO

//Random rnd = new Random();
//int numeroAleatorio = rnd.Next(1, 101);
//int intento;

//Console.WriteLine("¡Adivina el número entre 1 y 100!");

//do
//{
//    Console.Write("Introduce tu intento: ");
//    intento = int.Parse(Console.ReadLine());

//    if (intento < numeroAleatorio)
//    {
//        Console.WriteLine("El número es mayor.");
//    }
//    else if (intento > numeroAleatorio)
//    {
//        Console.WriteLine("El número es menor.");
//    }
//} while (intento != numeroAleatorio);

//Console.WriteLine("¡Felicidades! ¡Has adivinado el número " + numeroAleatorio + "!");