using System;
using System.Collections.Generic;

namespace P08.Company_Users
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companyRegister = new Dictionary<string, List<string>>();

            ReadInformation(companyRegister);

            PrintEmployees(companyRegister);

        }

        static void ReadInformation(Dictionary<string, List<string>> companyRegister)
        {
            string employeeInfo = string.Empty;

            while ((employeeInfo = Console.ReadLine()) != "End")
            {
                string[] information = employeeInfo.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = information[0];
                string employeeId = information[1];

                if (!companyRegister.ContainsKey(companyName))
                {
                    companyRegister.Add(companyName, new List<string>());
                }

                if (companyRegister[companyName].Contains(employeeId))
                {
                    continue;
                }
                else
                {
                    companyRegister[companyName].Add(employeeId);
                }
            }
        }
        static void PrintEmployees(Dictionary<string, List<string>> companyRegister)
        {
            foreach (KeyValuePair<string, List<string>> company in companyRegister)
            {
                Console.WriteLine(company.Key);

                foreach (string empleyee in company.Value)
                {
                    Console.WriteLine($"-- {empleyee}");
                }
            }
        }
    }
}
