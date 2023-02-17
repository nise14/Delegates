using Delegates;

Console.WriteLine("Delegates!!");

var person1 = new Person
{
    Name = "Pepito",
    Age = 30
};

var person2 = new Person
{
    Name = "Viejo Nicks",
    Age = 15
};

var persons = new List<Person>{
    person1, person2
};


PrintPersons(persons, AgeGreather20);
PrintPersons(persons, (x => x > 20));
PrintPersons(persons, Person.AgesGreatherTo20);

void PrintPersons(List<Person> persons, AgesGreatherTo20 filter)
{
    foreach (var person in persons)
    {
        if (filter(person.Age))
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}

bool AgeGreather20(int age)
{
    return age > 20;
}

public delegate bool AgesGreatherTo20(int age);
