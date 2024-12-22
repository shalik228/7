using System;

class Program
{
    static void Main(string[] args)
    {
        // Вывод шапки
        PrintHeader();

        Console.WriteLine("Выберите вид работы:");
        Console.WriteLine("1. Строительство");
        Console.WriteLine("2. Ремонт");
        Console.WriteLine("3. Уборка");

        int workType = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите объем работы (в часах):");
        int workVolume = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите срок выполнения работы (в днях):");
        int deadline = Convert.ToInt32(Console.ReadLine());

        int requiredWorkers = AssignTeam(workType, workVolume, deadline);

        Console.WriteLine($"\nНеобходимое количество работников: {requiredWorkers}");
        Console.WriteLine($"\nБригада составлена и приступит к работе в срок {deadline} дн.!");
    }

    static void PrintHeader()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("  Жилищно-коммунальные услуги");
        Console.WriteLine("=================================");
    }

    static int AssignTeam(int workType, int workVolume, int deadline)
    {
        int requiredWorkers = 0;

        // Определяем количество работников в зависимости от выбранного вида работы и объема
        if (workType == 1) // Строительство
        {
            requiredWorkers = workVolume / 4; // Один строитель работает 4 часа
        }
        else if (workType == 2) // Ремонт
        {
            requiredWorkers = workVolume / 3; // Один рабочий по ремонту работает 3 часа
        }
        else if (workType == 3) // Уборка
        {
            requiredWorkers = workVolume / 2; // Один уборщик работает 2 часа
        }

        // Увеличиваем количество работников в зависимости от срока
        if (deadline < 3) // Если срок меньше 3 дней
        {
            requiredWorkers = (int)(requiredWorkers * 1.5); // Увеличиваем количество работников на 50%
        }
        else if (deadline >= 3 && deadline < 5) // Если срок от 3 до 5 дней
        {
            requiredWorkers = (int)(requiredWorkers * 1.2); // Увеличиваем количество работников на 20%
        }

        return requiredWorkers;
    }
}
