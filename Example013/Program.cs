/* int[,] table = new int[3, 4];
void PrintAraay(int[,] matr)
{
  for (int rows = 0; rows < matr.GetLength(0); rows++)
  {
    for (int columns = 0; columns < matr.GetLength(1); columns++)
    {
      Console.Write($" {matr[rows, columns]} ");
    }
    Console.WriteLine();
  }
}
void FillAraay(int[,] matr)
{
  for (int rows = 0; rows < matr.GetLength(0); rows++)
  {
    for (int columns = 0; columns < matr.GetLength(1); columns++)
    {
      matr[rows, columns] = new Random().Next(1, 10);
    }
  }
}
PrintAraay(table);
FillAraay(table);
Console.WriteLine();
PrintAraay(table);


void PrintImage(int[,] image)
{
  for (int rows = 0; rows < image.GetLength(0); rows++)
  {
    for (int columns = 0; columns < image.GetLength(1); columns++)
    {
      //Console.Write($" {matr[rows, columns]} ");
      if (image[rows, columns] == 0) Console.Write($" ");
      else Console.Write($" + ");
    }
  }
}
PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);

void FillImage(int row, int col)
{
  if (pic[row, col] == 0)
  {
    pic[row, col] = 1;
    FillImage(row - 1, col);
    FillImage(row, col - 1);
    FillImage(row + 1, col);
    FillImage(row, col + 1);
  }
}
*/
double Factorial(int n)
{
  if (n == 1) return 1;
  else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
  Console.WriteLine($"{i} != {Factorial(i)} ");
  Console.WriteLine(Factorial(i));
}




int Fibonacci(int n)
{
  if (n == 1 || n == 2) return 1;
  else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 40; i++)
{
  Console.WriteLine(Fibonacci(i));
}