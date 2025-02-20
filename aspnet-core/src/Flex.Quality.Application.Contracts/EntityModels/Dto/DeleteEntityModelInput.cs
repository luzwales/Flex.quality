namespace Flex.Quality.EntityModels.Dto;

public class DeleteEntityModelInput
{
    public Guid AggregateId { get; set; }
    public Guid Id          { get; set; }
}