using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Relationship
    {
        //Reationship : one to many
        [JsonIgnore]
        public List<Employee> Employees { get; set; }
    }
}
