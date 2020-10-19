using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public Command CommandGeById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAppCommands()
        {
            throw new System.NotImplementedException();
        }
    }
}