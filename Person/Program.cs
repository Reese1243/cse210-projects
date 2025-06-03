class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("jim", "Bob", 20);

        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceman = new PoliceMan("cooper", "silver", 34, "Baton");
        Console.WriteLine(myPoliceman.GetPersonInformation());
    }
}
