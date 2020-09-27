using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using  commander.models;
using  commander.Data;
using System;
using AutoMapper;
using commander.dtos;

namespace  commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
 
public class  commandsController: ControllerBase
{       private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public commandsController(ICommanderRepo repository,IMapper mapper)
  {
 _repository = repository;
  _mapper = mapper;

  }
 //private MockCommanderRepo _repository = new MockCommanderRepo();
   [HttpGet]
 public ActionResult <IEnumerable<CommandReadDto>>   GetAllCommands()
  {
  
   var commandItems= _repository.GetAllCommands();
   return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
  }

    [Route("{id}",Name="GetCommandById")]
 public ActionResult <CommandReadDto> GetCommandById(int id)
  {
  
   var commandItem= _repository.GetCommandById(id);

  if(commandItem!=null)
  {
   //return Ok(commandItem);

    return Ok(_mapper.Map<CommandReadDto>(commandItem));

  //after usign dtoobject we can see that from the final response we are hidden "platform" field   which was an actual priperty 
  //of the  orignal model , but we want to hide it from external world 
  }
  return NotFound();
  }

  [HttpPost]
 public ActionResult <CommandReadDto> CreateCommand(CommandCreateDto commandcreatDto)
 {
var commadmodel = _mapper.Map<Command>(commandcreatDto);
_repository.createCommand(commadmodel);
_repository.SaveCahanges(); // without this line the data will not be saved to Db.
var commandReadDto =   _mapper.Map<CommandReadDto>(commadmodel);
//return Ok(commandReadDto); : This line works but give us a a 200 resonse ok. Actually as per architectual bes practices 
 //need a created reulst and a created location in the response header. For that purpose we can use the below syntax.


return CreatedAtRoute(nameof(GetCommandById),new {id=commandReadDto.Id},commandReadDto);


        //     Creates a Microsoft.AspNetCore.Mvc.CreatedAtRouteResult object that produces
        //     a Microsoft.AspNetCore.Http.StatusCodes.Status201Created response.
 }
}
}







