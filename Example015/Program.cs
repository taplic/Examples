string NumberRec(int a, int b)
{
  if (a <= b) return NumberRec(a + 1, b) + $"{a} ";
  else return String.Empty;
}
Console.WriteLine(NumberRec(1, 10));
Console.WriteLine();

int SumRec(int n)
{
  if (n == 0) return 0;
  else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10));
Console.WriteLine();

int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{

  if (length == word.Length)
  {
    Console.WriteLine($"{n++} {new String(word)}"); return;
  }
  for (int i = 0; i < alphabet.Length; i++)
  {
    word[length] = alphabet[i];
    FindWords(alphabet, word, length + 1);
  }
}
FindWords("аисв", new char[2]);