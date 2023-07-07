using ConnectionSQL.ModelInside;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConnectionSQL
{
    public class PplData : IPplData
    {
        public ISqlDataAccess _sql { get; set; }
        public PplData(ISqlDataAccess sqlData)
        {
            _sql = sqlData;
        }
        public Task<List<PersonModel>> GetPeople()
        {
            string str = "select * from dbo.Students";
            return _sql.LoadData<PersonModel, dynamic>(str, new { });
        }
        public Task InsertPerson(PersonModel person)
        {
            string str = @"insert into dbo.Students (Id,Name,Semester)
                            values (@Id,@Name,@Semester)";

            return _sql.SaveData(str, person);

        }
    }
}
