using System.Collections.Generic;
using commander.models;
using commander.Data;
using System.Linq;
using System;

namespace commander.Data
{

    public class SqlCommanderRepo : ICommanderRepo
    {

         private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context) => _context = context;

        public void createCommand(Command cmd)
        {
            if(cmd==null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            else
            {_context.Commands.Add(cmd);


            }
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(x=>x.Id==id);
        }

        public bool SaveCahanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateCommand(Command cmd)
        {
            //nothing
        }
    }
}