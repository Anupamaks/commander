
using System.ComponentModel.DataAnnotations;

namespace commander.dtos
{
 public class CommandCreateDto
    {
           [Required]
        [MaxLength(250)]
            public string HowTo {get; set;}
 
   [Required]
        public string Line {get; set;}

          [Required]
        public string Platform {get; set;}


    


        
    }

}