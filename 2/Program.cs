namespace tired;
interface IHello
{
    void sayhello();
    
}
class Programming : IHello
{
    public void sayhello()
    {
        Console.WriteLine("Hello world!");
    }
}
class chinchopa : IHello
{
    public void sayhello()
    {
        Console.WriteLine("Нихао");
    }
}
class japan : IHello
{
    public void sayhello()
    {
        Console.WriteLine("こんにちは");
    }
}
class ohio : IHello
{
    public void sayhello()
    {
        Console.WriteLine("Only on ohio");
    }
}
class german : IHello
{
    public void sayhello()
    {
        Console.WriteLine("sehr beängstigende Worte");
    }
}
internal class talked { 
    static void Main(string[] args)
    {
        List<IHello> nihao = new List<IHello>();
        nihao.Add(new chinchopa());
        nihao.Add(new japan()); 
        nihao.Add(new ohio());  
        nihao.Add(new Programming());
        nihao.Add(new german());
        foreach (IHello say in nihao) {
            say.sayhello();
                }
        Console.ReadKey(true);

    }
}
