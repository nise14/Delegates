namespace Delegates;

public class Person
{
    public string Name { get; init; } = null!;
    public int Age { get; init; }

    public static bool AgesGreatherTo20(int age){
        return age > 20;
    }
}