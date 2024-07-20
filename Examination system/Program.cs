﻿using System.Diagnostics;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject01 = new Subject(1, "C#");
            subject01.CreateExam();

            int StartExam = 0;
            do
            {
                Console.WriteLine($"Do You Want Start Exam Now ?   1.YES   2.NO ");
            } while (!int.TryParse(Console.ReadLine(), out StartExam) || (StartExam != 1 && StartExam != 2));

            if (StartExam == 1)
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                subject01.ExamOfTheSubject.ShowExam(SW);
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
            }

        }
    }
}