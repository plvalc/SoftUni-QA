static void PrintGadeWord(double grade)
{
    string gradeWord = "Excellent";

    if (grade >= 2.00 && grade < 3.00)
        gradeWord = "Fail";
    else if (grade < 3.50)
        gradeWord = "Average";
    else if (grade < 4.50)
        gradeWord = "Good";
    else if (grade < 5.50)
        gradeWord = "Very good";

    Console.WriteLine(gradeWord);
}

double gr = double.Parse(Console.ReadLine());

PrintGadeWord(gr);

