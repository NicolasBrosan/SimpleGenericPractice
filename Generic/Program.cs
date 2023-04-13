using Generic;

var sum = new SumAll();

Console.Write("Ingrese un número: ");
var test1 = Console.ReadLine();
var example1 = Convert.ToInt32(test1);
Console.Write("Ingrese el segundo número: ");
var test2 = Console.ReadLine();
var example2 = Convert.ToInt32(test2);

sum.Sum(example1, example2);

Console.WriteLine("-----------------------------------------------------------------");

var sum2 = new Generic<int>();
var example3 = sum2.Value = 10;
var example4 = sum2.Value = 20;

var result2 = example3 + example4;
Console.WriteLine($"La suma entre el número {example3} y {example4} es igual a {result2}");




