Student[] students = new Student[]
{
    new Student("John", 5, new int[] {90, 85, 95}),
    new Student("Mary", 8, new int[] {80, 75, 70}),
    new Student("Bob", 11, new int[] {65, 70, 75}),
    new Student("Jane", 9, new int[] {95, 90, 85}),
    new Student("Tom", 6, new int[] {70, 75, 80})
};

foreach (Student student in students)
{
    double average = student.AverageGrade();
    if (average > 85)
    {
        Console.WriteLine($"Congratulations {student.Name}! Your average grade is {average:F2}. Keep up the good work!");
    }
    else if (average < 70)
    {
        Console.WriteLine($"{student.Name}, you need some extra help. Your average grade is {average:F2}. Don't hesitate to ask for assistance.");
    }
    else
    {
        Console.WriteLine($"Well done {student.Name}! Your average grade is {average:F2}. Keep striving for improvement!");
    }
}