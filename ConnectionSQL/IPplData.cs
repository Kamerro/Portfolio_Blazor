using ConnectionSQL.ModelInside;

namespace ConnectionSQL
{
    public interface IPplData
    {
        ISqlDataAccess _sql { get; set; }

        Task<List<PersonModel>> GetPeople();
        Task InsertPerson(PersonModel person);
    }
}