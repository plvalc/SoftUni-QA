Dictionary<string, List<double>> students = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(student))
    {
        students.Add(student, new());
        students[student].Add(grade);
    }
    else
    {
        students[student].Add(grade);
    }
}

foreach (var kvp in students)
{
    if (kvp.Value.Average() < 4.5)
    {
        students.Remove(kvp.Key);
    }
}
foreach (var kvp in students)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
}