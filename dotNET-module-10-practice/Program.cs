using System;
using MyLibrary;

namespace dotNET_module_10_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ОСНОВНАЯ ЗАДАЧА");

            House house = new House();
            house.AddPart(new Basement());
            for (int i = 0; i < 4; i++)
                house.AddPart(new Wall());
            house.AddPart(new Door());
            for (int i = 0; i < 4; i++)
                house.AddPart(new Window());
            house.AddPart(new Roof());

            Team team = new Team();
            team.AddWorker(new Worker("Рабочий 1"));
            team.AddWorker(new Worker("Рабочий 2"));
            team.AddWorker(new TeamLeader("Бригадир"));

            team.BuildHouse(house);

            Console.WriteLine("ДОПОЛНИТЕЛЬНАЯ ЗАДАЧА");

            int[] grades = { 90, 85, 78, 92, 88 };
            IStudent student = new Student("Иван", "Иванов", grades);

            Console.WriteLine($"Имя студента: {student.GetName()}");
            Console.WriteLine($"Полное имя студента: {student.GetFullName()}");
            Console.WriteLine($"Средний балл студента: {student.GetAvgGrade()}");
        }
    }
}
