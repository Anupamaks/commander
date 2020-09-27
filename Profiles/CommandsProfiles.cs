
using commander.models;
using commander.dtos;
using AutoMapper;

namespace commander.Profiles

{
public class CommandsProfiles: Profile
{


     public CommandsProfiles()
    {
        CreateMap<Command,CommandReadDto>();
          CreateMap<CommandCreateDto,Command>();
    }
}

    
}