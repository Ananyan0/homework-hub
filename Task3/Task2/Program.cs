public class Student
{
    public string name;
    public int age;
    public float grade;

    public Student(string name, int age, float grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Grade: " + grade);
    }

}

public class Program
{
    public static void Main()
    {
        int studentsCount = 2;
        Student[] student1 = new Student[studentsCount];

        for (int i = 0; i < studentsCount; i++)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            float grade = float.Parse(Console.ReadLine());

            student1[i] = new Student(name, age, grade);
        }

        for (int i = 0; i < studentsCount; i++)
        {
            student1[i].DisplayDetails();
        }
        Console.ReadKey();
    }
}