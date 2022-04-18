using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            OfficerManager officerManager = new OfficerManager();
            while (true)
            {
                Console.WriteLine("Application Manager Officer");
                Console.WriteLine("Enter 1: To insert officer");
                Console.WriteLine("Enter 2: To search officer by name: ");
                Console.WriteLine("Enter 3: To show information officers");
                Console.WriteLine("Enter 4: To exit:");

                string line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        Console.WriteLine("Enter a: to insert Enginner");
                        Console.WriteLine("Enter b: to insert Worker");
                        Console.WriteLine("Enter c: to insert Staff");

                        string type = Console.ReadLine();
                        string name267, gender, address;
                        int age;
                        switch (type)
                        {
                            case "a":
                                Console.Write("Enter name: ");
                                name267 = Console.ReadLine();
                                while (true)
                                {
                                    Console.Write("Enter age: ");
                                    if (!int.TryParse(Console.ReadLine(), out age))
                                        Console.WriteLine("Your input is not valid. Please try again.");
                                    else
                                        break;
                                }
                                Console.Write("Enter gender: ");
                                gender = Console.ReadLine();
                                Console.Write("Enter address: ");
                                address = Console.ReadLine();
                                Console.Write("Enter branch: ");
                                string branch = Console.ReadLine();

                                Officer engineer = new Engineer(name267, age, gender, address, branch);
                                officerManager.addOfficer(engineer);
                                Console.WriteLine(engineer.ToString());
                                break;
                            case "b":
                                Console.Write("Enter name: ");
                                name267 = Console.ReadLine();
                                while (true)
                                {
                                    Console.Write("Enter age: ");
                                    if (!int.TryParse(Console.ReadLine(), out age))
                                        Console.WriteLine("Your input is not valid. Please try again.");
                                    else
                                        break;
                                }
                                Console.Write("Enter gender: ");
                                gender = Console.ReadLine();
                                Console.Write("Enter address: ");
                                address = Console.ReadLine();
                                int level;
                                while (true)
                                {
                                    Console.Write("Enter level: ");
                                    if (!int.TryParse(Console.ReadLine(), out level))
                                        Console.WriteLine("Your input is not valid. Please try again.");
                                    else
                                        break;
                                }

                                Officer worker = new Worker(name267, age, gender, address, level);
                                officerManager.addOfficer(worker);
                                Console.WriteLine(worker.ToString());
                                break;
                            case "c":
                                Console.Write("Enter name: ");
                                name267 = Console.ReadLine();
                                while (true)
                                {
                                    Console.Write("Enter age: ");
                                    if (!int.TryParse(Console.ReadLine(), out age))
                                        Console.WriteLine("Your input is not valid. Please try again.");
                                    else
                                        break;
                                }
                                Console.Write("Enter gender: ");
                                gender = Console.ReadLine();
                                Console.Write("Enter address: ");
                                address = Console.ReadLine();
                                Console.Write("Enter task: ");
                                string task = Console.ReadLine();

                                Officer staff = new Staff(name267, age, gender, address, task);
                                officerManager.addOfficer(staff);
                                Console.WriteLine(staff.ToString());
                                break;
                            default:
                                Console.WriteLine("Invalid.");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter name to search: ");
                        name267 = Console.ReadLine();
                        officerManager.searchOfficerByName(name267).ForEach(officer => {
                            Console.WriteLine(officer.ToString());
                        });
                        break;
                    case "3":
                        officerManager.showListInforOfficer();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid.");
                        continue;
                }
            }
        }
    }
}
