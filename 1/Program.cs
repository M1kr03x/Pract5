namespace cplusplus
{
    interface IAnimal
    {
       void Voice();
    }
    class Dog : IAnimal
    {
     public void Voice()
        {
            Console.WriteLine("Гав!");
        }
    }
class Cat : IAnimal { 
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }
    class Owl : IAnimal { 
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 0) && (currentTime <= 8))
            {
                Console.WriteLine("Тише, я сплю");
            }
            else
            {
                Console.WriteLine("Bruh");
            }
        }
    }
class Capybara : IAnimal { 
    
        public void Voice()
        {
            Console.WriteLine("Ка-пи-ба-ра капибара капибара капибара капибара");
        }
    }
class parrot : IAnimal { 
    

     public bool cageclose;
     private int GetCurrentTime()
        {
         return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int time = GetCurrentTime();
            if (time > 0 && time < 8)
            {
                cageclose = true;
            }
            else cageclose = false;
            if (cageclose == true)
            {
                Console.WriteLine("Чирика не будет");
            }
            else Console.WriteLine("Почалося");
        }
}
     class petster { 
    
        static void pet(IAnimal abstract1)
        {
            Console.WriteLine("Глажу челикса, а он мне значит говорит");
            abstract1.Voice();
        }
        static void Main(string[] args)
        {
            List<IAnimal> zoolander = new List<IAnimal>();
            zoolander.Add(new Dog());
            zoolander.Add(new Cat());
            zoolander.Add(new Owl());
            zoolander.Add(new Capybara());
            zoolander.Add(new parrot());
            foreach (IAnimal abstract1 in zoolander)
            {
                pet(abstract1);
            }
            Console.ReadKey(true);
        }
    }
}
/* Короче делал эти приколы на плюсах, но эти абстракты меня так ..., что я решил короче просто на шарпе по примеру сделать. Я над этим кодом часа два сидел наверное,
 * а по итогу словил жёсткий фейл. И я ведь его почти сделал, но этот проклятый лист не дал мне создать экземпляр абстрактного класса, прямо как и вектор, поэтому я словил тильт и пошёл
 * делать эту практу на шарпе.
 * 
#define __STDC_WANT_LIB_EXT1__ 1
#include <time.h>
#include <stdio.h>
#include <ctime>
#include <iostream>
#include <vector>
#include <list>
#pragma warning(disable : 4996)

class Ianimal {
    public:
    virtual void voice() = 0;
};
class Dog :public Ianimal {
public:
    void voice() override {
        std::cout << "Гав"<< std::endl;
    }
};
class Owl :public Ianimal {
private:
    long GetCurrentTime() {
        time_t now = time(0);
        char* dt = ctime(&now);
        long result = strtol(dt, &dt, 10) + 1;
        return result;
    }
public:
    void voice() override {
        char eight = 8;
        char twenty = 21;
        long chel = GetCurrentTime();
        
        if ((chel >= 8) and (chel <= 21)) {
            std::cout << "Тише, я сплю";
        }
        else {
            std::cout << "Вывести системное время в плюсах без ошибок это просто пытка";
        }
            
        
    }
    

};
class Cat :public Ianimal {
public:
    void voice() override {
        std::cout << "Мяу" << std::endl;
    }

  

};
class parrot :public Ianimal {
public:
    bool cageclose;
    long GetCurrentTime() {
        time_t now = time(0);
        char* dt = ctime(&now);
        long result = strtol(dt, &dt, 10) + 1;
        return result;
    }
    void voice() override  {
        long result = GetCurrentTime();
        if (result > 0 and result < 8) {
            cageclose = true;
        }
        else cageclose = false;
        if (cageclose == true) {
            std::cout << "Чирика не будет";
        }
        else std::cout << "Почалося";
        
        
    }

};
class Capybara :public Ianimal {
public:
    void voice() override {
        std::cout << "Ка-пи-ба-ра капибар капибара капибара капибара";
    }

};
class Pet {
public:

};

int main()
{
    Dog a;
    Cat b;
    Capybara c;
    parrot d;
    Owl e;
    std::list<Ianimal> zaibalo{ a,b,c,d,e };
for (auto n : zaibalo){

}
};
   
   /* time_t now = time(0);
    char* dt = ctime(&now);
    std::cout << "The local date and time is: " << dt << std::endl; */

