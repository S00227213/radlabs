using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataModel
{
    public class StudentMap: ClassMap<Student>
    {
        
        public StudentMap()
        {
            string format = "dd/MM/yyyy";
            var msMY = CultureInfo.GetCultureInfo("en-ie");

            Map(m => m.StudentID).Name("StudentID");
            Map(m => m.FirstName).Name("FirstName");
            Map(m => m.SecondName).Name("SecondName");
            Map(m => m.RegistrationDate).Name("DateRegistered")
                            .TypeConverterOption.Format(format)
                            .TypeConverterOption.CultureInfo(msMY);
        }

       
    }
}
