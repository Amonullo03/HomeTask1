// public class Student
// {
//     public string name;
//     public int level;
//     public int [] grades;

//     public double AverageGrade()
//     {
//         double sum = 0;
//         foreach (int grade in grades)
//         {
//             sum += grade;
//         }
//         return sum / grades.Length;
//     }
// }

public class Student
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int[] Grades { get; set; }

    public Student(string name, int level, int[] grades)
    {
        Name = name;
        Level = level;
        Grades = grades;
    }

    public double AverageGrade()
    {
        double sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Length;
    }
}
