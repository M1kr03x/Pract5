using System.Reflection;

namespace tirtef4
{
interface IShare
    {
        void Draw(int pointer);
    }
class VerticalLine : IShare
    {
public void Draw(int pointer)
        {
            for (int i = 0; i < pointer; i++)
            {
                Console.WriteLine("|");
            }
        }
    }
class HorizontalLine : IShare
    {
        public void Draw(int pointer)
        {
            for (int i = 0; i < pointer; i++)
            {
                Console.Write("-");
            }
        }
    }
class Square : IShare
    {
 public void Draw(int pointer)
        {
            Console.WriteLine();
            for (int i = 0; i < pointer; i++)
            {
                for (int j = 0; j < pointer; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
internal class Program
    {
static void Main(string[] args){
List<IShare> figures = new List<IShare>();
figures.Add(new VerticalLine());
figures.Add(new HorizontalLine());
figures.Add(new Square());
foreach (IShare drawing in figures)
{
                drawing.Draw(15);
    Console.WriteLine();
}
Console.ReadKey(true);
}
}
}