using System;

namespace _1._31._2023_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car pc = new Car("Mika", "HJ", 90, 100, 25);
            pc.AddFuel(70);
            Console.WriteLine(pc.CurrentFuel);
            pc.AddFuel(5);
            Console.WriteLine(pc.CurrentFuel);


            Console.WriteLine("Please enter students count");
            int count = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[count];


            for (int i = 0; i < students.Length; i++)
            {
                string Fullname;
                do
                {
                    Console.WriteLine("Please enter student name");
                    Fullname = Console.ReadLine();
                    var result = HasFullName(Fullname);
                    Console.WriteLine(result);
                } while (string.IsNullOrWhiteSpace(Fullname));


                string groupno;
                do
                {
                    Console.WriteLine("Please enter group number");
                    groupno = Console.ReadLine();
                    var result1 = GroupNo(groupno);
                    Console.WriteLine(result1);

                } while (string.IsNullOrWhiteSpace(groupno));


                Student stud = new Student
                {
                    Fullname = Fullname,
                    GroupNo = groupno,
                };
                students[i] = stud;
            }

            Console.WriteLine("1. See all students");
            Console.WriteLine("2. Search among students ");
            Console.WriteLine("3. Add student");
            Console.WriteLine("0. Out the menu");

            string opr;
            do
            {
                Console.WriteLine("Please select an operation");
                opr = Console.ReadLine();
                switch (opr)
                {
                    case "1":
                        foreach (var item in students)
                        {
                            Console.WriteLine($"FullName {item.Fullname}, GroupNo {item.GroupNo}");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Please enter the search value");
                        string Lp = Console.ReadLine();
                        for (int i = 0; i < students.Length; i++)
                        {
                            if ((students[i].Fullname.Contains(Lp) || (students[i].GroupNo.Contains(Lp))))
                            {
                                Console.WriteLine($"FullName: {students[i].Fullname}  GroupNo : {students[i].GroupNo}");
                            }
                        }
                        break;
                    case "3":

                        Console.WriteLine("Enter the group number");
                        string groupNo = Console.ReadLine();

                        foreach (var item in students)
                        {

                            if (item.GroupNo == groupNo)
                            {
                                Console.WriteLine($"FullName: {item.Fullname}  GroupNo : {item.GroupNo}");
                            }

                        }
                        break;


                    case "0":
                        Console.WriteLine("Thanks");
                        break;
                }
            } while (opr != "0");


        }

        static bool HasFullName(string inp)
        {
            inp = inp.Trim();
            var result = inp.Split(' ');
            string[] Result = new string[0];
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != "")
                {
                    Array.Resize(ref Result, Result.Length + 1);
                    Result[Result.Length - 1] = result[i];
                }
            }
            for (int i = 0; i < Result.Length; i++)
            {
                if (char.IsUpper(Result[i][0]) == false)
                {
                    return false;
                }
                else
                {
                    for (int j = 1; j < Result[i].Length; j++)
                    {
                        if (char.IsLower(Result[i][j]) == false)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        static bool GroupNo(string groupno)
        {
            if (!char.IsUpper(groupno[0]))
            {
                return false;
            }

            for (int i = 1; i < groupno.Length; i++)
            {
                if (char.IsDigit(groupno[i]))
                {
                    return true;
                }
            }
            return false;
        }
    
    }
}
