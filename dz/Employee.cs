using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dz
{
    using System.ComponentModel.DataAnnotations;
    public class Employee
    {
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        [XmlAttribute()]
        public string FirstName;

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        [XmlAttribute()]
        public string LastName;

        /// <summary>
        /// Должность
        /// </summary>
        [XmlAttribute()]
        public string Post;

        /// <summary>
        /// Дата рождения
        /// </summary>
        [XmlAttribute()]
        public DateTime BirthDay;

        /// <summary>
        /// Признак руководителя подразделения
        /// </summary>
        [XmlAttribute()]
        public bool isHead;
    }
}
