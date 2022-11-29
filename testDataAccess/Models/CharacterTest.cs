using System.ComponentModel.DataAnnotations;

namespace testDataAccess.Models
{
    public class CharacterTest
    {
        public int id { get; set; }
        public string name { get; set; }
        public int armorClass { get; set; }
        public int? initiative { get; set; }
        public string range { get; set; }
        public string? status { get; set; }

        public CharacterTest()
        {
            name = "no name entered";
            range = "no range entered";
        }

        public CharacterTest(CharacterTest characterTest)
        {
            this.id = characterTest.id;
            this.name = characterTest.name;
            this.armorClass = characterTest.armorClass;
            this.initiative = characterTest.initiative;
            this.range = characterTest.range;
            this.status = characterTest.status;
        }
    }
}
