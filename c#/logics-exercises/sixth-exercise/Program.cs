// using System.Threading.Tasks.Dataflow;
namespace c_ {
  class Program {
    static void Main () {
      string Word = Console.ReadLine();
      for(int i = 0; i < Word.Length; i++) {
        Console.Write(Word.ToUpper()[i] + "-");
      }
    }
  }
}