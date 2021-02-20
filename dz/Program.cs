using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace dz
{
    class Program
    {
        const string stateFileName = @"d:\company.xml";
        static void Main(string[] args)
        {
            var company = new Company();
            company = Company.Load(stateFileName);

            var emp = new Employee()
            {
                FirstName = "Mus'ab",
                LastName = "Umayr",
                Post = "Помощник ...",
                BirthDay = new DateTime(1990, 5, 23),
                isHead = false,
            };

            var subdivision = new Subdivision()
            {
                SubdivisionName = "First",
            };
            subdivision.AddEmployee(emp);

            company.AddSubdivision(subdivision);

            company.Save(stateFileName);

            Console.ReadLine();
        }


    }
}
