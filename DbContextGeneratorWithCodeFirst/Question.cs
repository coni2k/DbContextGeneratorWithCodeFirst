namespace DbContextGeneratorWithCodeFirst
{
    using System.Collections.Generic;
    
    public partial class Question
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
