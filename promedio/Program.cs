String numero;
double primeraNota;
double segundaNota;
double terceraNota;
double cuartaNota;

Console.Write("Primera nota: ");
numero = Console.ReadLine();
primeraNota = Convert.ToDouble(numero);
Console.Write("Segunda nota: ");
numero = Console.ReadLine();
segundaNota = Convert.ToDouble(numero);
Console.Write("Trecera nota: ");
numero = Console.ReadLine();
terceraNota = Convert.ToDouble(numero);
Console.Write("cuarta nota: ");
numero = Console.ReadLine();
cuartaNota = Convert.ToDouble(numero);

double promedio = (primeraNota + segundaNota + terceraNota + cuartaNota) / 4;
Console.Write("Su promedio fue "+ promedio);