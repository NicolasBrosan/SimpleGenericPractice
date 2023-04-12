using Generic;

var sum = new SumAll();

Console.Write("Ingrese un número: ");
var test1 = Console.ReadLine();
var example1 = Convert.ToInt32(test1);
Console.Write("Ingrese el segundo número: ");
var test2 = Console.ReadLine();
var example2 = Convert.ToInt32(test2);

sum.Sum(example1, example2);
