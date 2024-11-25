namespace ApiEndPoint.ViewModel
{
    public class SectionVm
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid SeasionId { get; set; }
        public Guid? CategoryId { get; set; }
        public int CourseLevel { get; set; }
        public string StatusMessage { get; set; }
    }

}
