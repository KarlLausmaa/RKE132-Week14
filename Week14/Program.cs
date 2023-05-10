
Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);


Dog neighBoursDog = new Dog("Loki");



Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My dogs name is {neighBoursDog.Name}");

myDog.Rename("bad boy");

while(myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfHapiness;


    public Dog(string Name)
    {
        _name = Name;
        _levelOfHapiness = 0;
    }


    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHapiness; }
    }


    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }


    public void Bark()
    {
        Console.WriteLine("Auh");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle");
    }

}