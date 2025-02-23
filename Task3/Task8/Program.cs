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

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student Name: {name}, Age: {age}, Grade: {grade}");
    }
}

public class Teacher
{
    public string name;
    public string subject;
    public int YearsOfExperience;

    public Teacher(string name, string subject, int YearsOfExperience)
    {
        this.name = name;
        this.subject = subject;
        this.YearsOfExperience = YearsOfExperience;
    }

    public void DisplayTeacherInfo()
    {
        Console.WriteLine($"Teacher Name: {name}, Subject: {subject}, Years: {YearsOfExperience}");
    }

}

public class School
{
    private Student[] students;
    private Teacher[] teachers;

    public School(Student[] students, Teacher[] teachers)
    {
        this.students = students;
        this.teachers = teachers;
    }

    public void DisplaySchoolInfo()
    {
        Console.WriteLine("\nSchool Students:");
        foreach (var student in students)
        {
            student.DisplayStudentInfo();
        }

        Console.WriteLine("School Teachers:");
        foreach (var teacher in teachers)
        {
            teacher.DisplayTeacherInfo();
        }
    }
}



public class Program
{
    public static void Main()
    {
        Student[] students = new Student[2];
        Teacher[] teachers = new Teacher[2];

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"What is the student's name?: ");
            string student_name = Console.ReadLine();
            Console.WriteLine($"{student_name} how old are you?: ");
            int student_age = int.Parse(Console.ReadLine());
            Console.WriteLine($"What is your grade: ");
            float student_grade = float.Parse(Console.ReadLine());

            students[i] = new Student(student_name, student_age, student_grade);
        }

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"What is the teacher's name: ");
            string teacher_name = Console.ReadLine();
            Console.WriteLine($"{teacher_name} what is your subject?: ");
            string teacher_subject = Console.ReadLine();
            Console.WriteLine($"{teacher_name} how many years of experience you have?: ");
            int teacher_years = int.Parse(Console.ReadLine());

            teachers[i] = new Teacher(teacher_name, teacher_subject, teacher_years);
        }


        School school = new School(students, teachers);

        school.DisplaySchoolInfo();


        float high_grade = students[0].grade;

        for (int i = 1; i < 2; i++)
        {
            if (students[i].grade > high_grade)
            {
                high_grade = students[i].grade;
            }
        }
        Console.WriteLine("The highest grade: " + high_grade);
        //////////////////////////////////////////////////////

        for (int i = 0; i < 2; i++)
        {
            if (teachers[i].YearsOfExperience < 2)
            {
                Console.WriteLine("Less then 2 years of experience: " + teachers[i].name);
            }
        }

        Console.ReadKey();
    }
}