Console.WriteLine($"Digite um numero para saber sua tabuada!");
int value = Convert.ToInt32( Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
  Console.WriteLine($"{value} * {i} = {value * i} ");
}
