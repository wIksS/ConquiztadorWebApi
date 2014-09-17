namespace GameDb.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
 
        public string Password { get; set; }

        public int? Result { get; set; }
    }
}
