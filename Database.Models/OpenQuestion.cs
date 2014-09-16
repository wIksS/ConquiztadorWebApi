namespace Database.Models
{
    using System;

    public class OpenQuestion
    {
        public int Id { get; set; }
        
        public string Question { get; set; }
        
        public int CorrectAnswer { get; set; }
    }
}
