using System.Collections.Generic;
using commander.models;

namespace commander.Data
{

    public class MockCommanderRepo : ICommanderRepo
    {
        public void createCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
           var commands = new List<Command>
            {
             new Command{Id=1,HowTo="Boil an egg", Line="boil water",Platform="Kettle& Pan" },
             new Command{Id=1,HowTo="Make sandwitch", Line="Take bread",Platform="Knife" },
              new Command{Id=1,HowTo="Make Tea", Line="Place tea bag in water",Platform="Kettle&mug" },
            };
  
         return commands;

        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=1,HowTo="Boil an egg", Line="boil water",Platform="Kettle& Pan" };
        }

        public bool SaveCahanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}