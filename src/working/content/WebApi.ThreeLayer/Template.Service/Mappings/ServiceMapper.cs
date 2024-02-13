namespace Template.Service.Mappings;

[Mapper]
public partial class ServiceMapper
{
    public partial SampleDto MapToSampleDto(SampleDataModel data);
    public partial IEnumerable<SampleDto> MapToSampleDtos(IEnumerable<SampleDataModel> datas);
}