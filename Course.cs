using System;
using System.Collections.Generic;
using System.Linq;

public class Course
{
    public string CourseId { get; set; }
    public string CourseName { get; set; }

    private List<Student> students = new List<Student>();

    public Course(string id, string name)
    {
        CourseId = id;
        CourseName = name;
    }

    public void AddStudent(Student s)
    {
        students.Add(s);
    }

    public void ShowStudents()
    {
        foreach (Student s in students)
        {
            s.ShowInfo();
        }
    }

    public void ShowMaxScore()
    {
        if (students.Count == 0) return;

        double max = students.Max(s => s.Score);
        Console.WriteLine("Max Score = " + max);
    }

    public void ShowMinScore()
    {
        if (students.Count == 0) return;

        double min = students.Min(s => s.Score);
        Console.WriteLine("Min Score = " + min);
    }

    public void ShowAverageScore()
    {
        if (students.Count == 0) return;

        double avg = students.Average(s => s.Score);
        Console.WriteLine("Average Score = " + avg);
    }
}