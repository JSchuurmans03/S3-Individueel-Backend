using testDataAccess.Models;

namespace testDataAccess.Data
{
    public class CharacterTestService
    {
        private readonly AppDbContext _context;

        public CharacterTestService(AppDbContext context)
        {
            _context = context;
        }

        public List<CharacterTest> CharacterTests()
        {
            return _context.Character.ToList();
        }
    }
}
