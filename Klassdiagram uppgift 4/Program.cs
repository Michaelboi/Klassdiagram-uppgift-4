using Klassdiagram_uppgift_4;

void Djur()
{
    // jag använder get och set funktioner här
    Animal.Dog hund = new Animal.Dog();
    hund.setName("Malkolm");
    Console.WriteLine("namn: " + hund.getName());
    hund.setsvanslängd(50);
    Console.WriteLine("svanslängd: " + hund.getsvanslängd());
    hund.Bark();
    
}
Djur();