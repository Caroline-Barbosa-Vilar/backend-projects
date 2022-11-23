namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] nome = new string[3];
      
      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine("Digite um nome: ");
        nome[i] = Console.ReadLine();
      }
    }
  }
}