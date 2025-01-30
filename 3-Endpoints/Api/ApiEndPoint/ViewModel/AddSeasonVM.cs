namespace ApiEndPoint.ViewModel
{
    public class AddSeasonVM
    {
        public Guid CreatedUserId { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; }

        public string SeasonsDescription { get; set; }

    }
}
