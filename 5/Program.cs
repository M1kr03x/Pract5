
namespace tiredfive
{
    interface IMagic
    {
        string Name
        {
            get; set;
        }
        int Mana
        {
            get;set;
        }
        void usespell();
    }
    class Spell : IMagic
    {
public string Name
        {
            get; set;
        }
public int Mana
        {
            get; set;
        }
private string Effect
        {
            get; set;
        }
public Spell(string name, int mana, string effect)
        {
            Name = name; Mana = mana; Effect = effect;
        }
public void usespell()
        {
            Console.WriteLine(Effect);
        }
    }
class Magician
    {
public string Name
        {
            get; private set;
        }
public int Mana
        {
            get; private set;
        }
public Magician(string name, int mana)
        {
            Name = name; Mana = mana;
        }
public void usespell()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Mana);
        }
public void CastSpell(Spell spell)
        {
if (Mana >= spell.Mana)
   {
       Mana -= spell.Mana;
       Console.WriteLine($"{Name} кастует");
       spell.usespell();
    }
else
    {
        int mana = spell.Mana - Mana;
        Console.WriteLine($"Для юзания {spell.Name} не хватает {mana} вот столько маны. Хрпяните так называемой bottle");
     }
   }
 }
internal class tryung
    {
static void Main(string[] args)
{
Spell spellc = new Spell("Спеллкаст", 100, "Чёто происходит");
Spell nextspell = new Spell("Очередной спелыч", 60, "Ура победа");
Magician harryPotter = new Magician("Wizzzard name", 160);
harryPotter.CastSpell(spellc);
harryPotter.CastSpell(nextspell);
Console.ReadKey(true);
}
}
}