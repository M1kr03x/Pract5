namespace capybara
{
    interface IFilter
    {
        string Execute(string textLine);
    }
class DigitFilter : IFilter { 
public string Execute(string textline) { 
  string text = "";
  char[] except = {'!','@','#','$','%','^','&','*','(',',','.','/','"','+','=','-','_','№',' ', ','};
     for (int i = 0; i < textline.Length; i++) {
                if (char.IsLetter(textline[i]) || Array.IndexOf(except, textline[i]) >= 0)
                {
                    text += textline[i];
                }
                
            }
            return text;
        }
    }
class LetterFilter : IFilter { 
public string Execute(string textline) { 
            string text = "";
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsDigit(textline[i]))
                {
                    text += textline[i];
                }
            }
            return text;
 }
}
internal class launch { 
 
static void Main(string[] args) { 
        
DigitFilter texti4 = new DigitFilter();
Console.WriteLine(texti4.Execute("Капибара – капибара капибара капибара – капибара"));
LetterFilter symboli4 = new LetterFilter();
Console.WriteLine(symboli4.Execute("5пи3урааыаывавы3423Чин43Чопа43243Хук31321Жо321321П2312А"));
Console.ReadKey(true);
      }
   }
}


/* {'!','@','#','$','%','^','&','*','(',',','.','/','"','+','=','-','_','№',' ', ','}; */