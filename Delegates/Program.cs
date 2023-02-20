using Delegates;

#region Delegates Basic
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

#endregion

Console.WriteLine();

#region Actions
Console.WriteLine("Actions");

Action action1 = delegate ()
{
    Console.WriteLine("Hello world!");
};

action1();

Action<string> action2 = delegate (string name)
{
    var reverse = name.ToArray();
    Array.Reverse(reverse);
    Console.WriteLine(new string(reverse));
};

action2("Nicolas");

Action<string> action3 = (string name) =>
{
    var reverse = name.ToArray();
    Array.Reverse(reverse);
    Console.WriteLine(new string(reverse));
};

action3("Nicks");

Action<string> action4 = (name) =>
{
    var reverse = name.ToArray();
    Array.Reverse(reverse);
    Console.WriteLine(new string(reverse));
};

action4("anita lava la tina");

void ReverseText(string text)
{
    var reverse = text.ToCharArray();
    Array.Reverse(reverse);
    Console.WriteLine(new string(reverse));
}

Action<string> action5 = name => ReverseText(name);

action3("Oro");

Action<int, int> action6 = (x, y) =>
{
    var sum = x + y;
    var text = sum switch
    {
        < 0 => "Suma negativa",
        > 0 => "Suma positiva",
        _ => "Valor cero"
    };

    Console.WriteLine(text);
};

action6(0, -1);
#endregion

#region Functions
Console.WriteLine("FUNCTIONS");
//El ulitmo int es el tipo de valor que retorna la funcion
Func<int, int, int> suma = (num1, num2)=>num1+num2;
Console.WriteLine(suma(1,2));

Func<Person, bool> func2 = p => p.Age > 20;
Console.WriteLine(func2(person1));
#endregion
public delegate bool AgesGreatherTo20(int age);

