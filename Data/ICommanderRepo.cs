using System.Collections.Generic;
using commander.models;

namespace commander.Data
{

    public interface  ICommanderRepo
    {
        bool SaveCahanges();
       IEnumerable<Command> GetAllCommands();
       Command GetCommandById(int id);
       void createCommand(Command cmd);
       void UpdateCommand(Command cmd);

  
    }
} 