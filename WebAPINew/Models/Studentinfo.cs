using System.ComponentModel.DataAnnotations;

namespace WebAPINew.Models
{
    public class Studentinfo
    {
        
        public  Guid Id { get; set; }
        public string  stdName{ get; set; }
        public string stdGender { get; set; }
        public int stdAge { get; set; }
        public int stdClass { get; set; }

    }
}
