namespace SIGN.Domain.Classes
{
    public class Recommendation : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public RecommendationGrade Grade { get; set; }
        public Guideline Guideline { get; set; }
    }
}
