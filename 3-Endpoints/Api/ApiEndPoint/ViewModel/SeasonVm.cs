namespace ApiEndPoint.ViewModel
{
    public class SeasonVm
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; }

        public string SeasonsDescription { get; set; }
    }
}
