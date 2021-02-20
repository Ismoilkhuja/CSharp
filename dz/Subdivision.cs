using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dz
{
    public class Subdivision
    {
        /// <summary>
        /// Название подразделения
        /// </summary>
        [XmlAttribute()]
        public string SubdivisionName;

        /// <summary>
        /// Массив подразделений
        /// </summary>
        [XmlElement()]
        public Subdivision[] Subdivisions;

        /// <summary>
        /// Массив сотрудников
        /// </summary>
        [XmlElement()]
        public Employee[] Employees;

       /// <summary>
       /// Добавление сотрудника в подразделение
       /// </summary>
       /// <param name="employee">Сотрудник</param>
        public void AddEmployee(Employee employee)
        {
            if (Employees == null)
            {
                Employees = new Employee[] { employee };
            }
            else
            {
                var list = Employees.ToList();
                list.Add(employee);
                Employees = list.ToArray();
            }
        }

        /// <summary>
        /// Добавление подразделения в подразделение
        /// </summary>
        /// <param name="subdivision">Подразделение</param>
        public void AddSubdivision(Subdivision subdivision)
        {
            if (Subdivisions == null)
            {
                Subdivisions = new Subdivision[] { subdivision};
            }
            else
            {
                var list = Subdivisions.ToList();
                list.Add(subdivision);
                Subdivisions = list.ToArray();
            }
        }


    }
}
