namespace BaseTemplate.Dtos
{
    public interface IBaseEntityDto
    {
        int Id { get; set; }
    }
    public class BaseEntityDto : IBaseEntityDto
    {
        public int Id { get; set; }
    }
}
