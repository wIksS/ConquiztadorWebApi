namespace Database.Models
{
    public class ClosedQuestion
    {
        public int Id { get; set; }
        
        public string Question { get; set; }
        
        public string AnswerA { get; set; }
        
        public string AnswerB { get; set; }
        
        public string AnswerC { get; set; }
        
        public string AnswerD { get; set; }
        
        public string CorrectAnswer { get; set; }
    }
}