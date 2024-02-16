double basse, altura, area;

Console.WriteLine("Ingrese la base de un triangulo: ");
basse = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura de un triangulo: ");
altura = double.Parse(Console.ReadLine());
area = (basse * altura) / 0.5;
Console.WriteLine("El area del triangulo es:" + area);

double radio, volumen;

Console.WriteLine("Ingrese el radio de una esfera: ");
radio = double.Parse(Console.ReadLine());
volumen = 4 / 3 * Math.PI * Math.Pow(radio, 3);
Console.WriteLine("El volumen de la esfera es: " + volumen);

double x1, x2, y1, y2, distancia;

Console.WriteLine("Ingrese la coordenada para X1: ");
x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la coordenada pra Y1: ");
y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la coordenada para X2: ");
x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la coordenada para Y2: ");
y2 = double.Parse(Console.ReadLine());
distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("La distancia entre los puntos es: " + distancia);

double C, F;

Console.WriteLine("Ingrese la temperado en Celsius: ");
C = double.Parse(Console.ReadLine());
F = C * 9 / 5 + 32;
Console.WriteLine("La temperatura en Fahrenheit es: " + F);

double fahrenheitt, celsiuss;

Console.WriteLine("ingrese la temperatura en Fahrenheit: ");
fahrenheitt = double.Parse(Console.ReadLine());
celsiuss = (fahrenheitt - 32) * 5 / 9;
Console.WriteLine("La temperatura en Celsius es: " + celsiuss);
