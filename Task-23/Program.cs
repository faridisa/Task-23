using System.Text.Json;
using Task_23.Employess;

if (!Directory.Exists("Files"))
{
    Directory.CreateDirectory("Files");
}
if (!File.Exists("Files/Database.json"))
{
    Department department = new Department();
    string json = JsonSerializer.Serialize(department);
    File.WriteAllText("Files/Database.json", json);
}


while (true)
{
    Console.WriteLine("1.Add employee");
    Console.WriteLine("2.Get employee by id");
    Console.WriteLine("3. Remove employee");
    Console.WriteLine("0. Quit");

    int secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Salary:");
            decimal salary = decimal.Parse(Console.ReadLine());

            Employe employe = new Employe();
            employe.Id = id;
            employe.Name = name;
            employe.Salary = (double)salary;
            break;
        case 2:
            break;
        case 3:
            break;
        case 0:
            return;
    }
}