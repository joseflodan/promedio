String numero;
double[] notas = new double[4];

Console.Write("Primera nota: ");
numero = Console.ReadLine();
notas[0] = Convert.ToDouble(numero);
Console.Write("Segunda nota: ");
numero = Console.ReadLine();
notas[1] = Convert.ToDouble(numero);
Console.Write("Trecera nota: ");
numero = Console.ReadLine();
notas[2] = Convert.ToDouble(numero);
Console.Write("cuarta nota: ");
numero = Console.ReadLine();
notas[3] = Convert.ToDouble(numero);

double promedio = notas.Sum() / notas.Length;
Console.Write("Su promedio fue "+ promedio);