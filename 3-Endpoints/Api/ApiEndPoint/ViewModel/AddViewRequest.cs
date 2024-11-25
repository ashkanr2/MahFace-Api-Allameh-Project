namespace ApiEndPoint.ViewModel
{
    public class AddViewRequest
    {
        public Guid SectionId { get; set; }
        public Guid UserId { get; set; }
        public TimeOnly LastVideoTime { get; set; }
    }

}
