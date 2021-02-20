using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace dz
{
    [XmlRoot(ElementName ="Company")]
    public class Company
    {
        /// <summary>
        /// Название компании
        /// </summary>
        [XmlAttribute()]
        public string CompanyName;

        /// <summary>
        /// Массив подразделений
        /// </summary>
        [XmlElement()]
        public Subdivision[] Subdivisions;


        public static Company Load(string name)
        {
            try
            {
                // Объект для сериализации
                XmlSerializer ser = new XmlSerializer(typeof(Company));

                // Открыть файл для чтения XML-данных
                using (XmlReader rdr = XmlReader.Create(name))
                {
                    // Десериализация и формирование объекта в памяти
                    return (Company)ser.Deserialize(rdr);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                // На всякий случай сообщим
                Console.WriteLine($"Файл {name} не найден, будет создан новый файл.");
                // Создадим новое пустое состояние
                return new Company();
            }
            catch (Exception ex)
            {
                // На всякий случай сообщим
                Console.WriteLine(ex);
                // Создадим новое пустое состояние
                return new Company();
            }
        }

        /// <summary>
        /// Сериализация объекта в файл
        /// </summary>
        /// <param name="name">Имя файла</param>
        public void Save(string name)
        {
            // Объект для сериализации
            XmlSerializer ser = new XmlSerializer(typeof(Company));
            // Настройка человекочитаемого формирования XML-файла
            XmlWriterSettings s = new XmlWriterSettings()
            {
                Indent = true // каждый тег на своей строке
            };
            // Писатель в файл
            using (XmlWriter wrt = XmlWriter.Create(name, s))
            {
                // Собственно сериализация
                ser.Serialize(wrt, this);
            }
        }

        /// <summary>
        /// Добавление подразделения
        /// </summary>
        /// <param name="subdiv">Подразделение</param>
        public void AddSubdivision(Subdivision subdiv)
        {
            if (Subdivisions == null)
            {
                Subdivisions = new Subdivision[] { subdiv };
            }
            else
            {
                var list = Subdivisions.ToList();
                list.Add(subdiv);
                Subdivisions = list.ToArray();
            }
        }




    }
}
