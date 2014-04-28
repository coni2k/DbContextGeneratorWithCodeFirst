namespace DbContextGeneratorWithCodeFirst
{
    public partial class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Value { get; set; }
    
        public virtual Question Question { get; set; }
    }
}
