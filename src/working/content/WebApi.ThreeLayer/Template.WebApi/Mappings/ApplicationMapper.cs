using System.Collections;

namespace Template.WebApi.Mappings;

[Mapper]
public partial class ApplicationMapper
{
    public partial SampleViewModel MapToSampleViewModel(SampleDto dto);
    public partial IEnumerable<SampleViewModel> MapToSampleViewModels(IEnumerable<SampleDto> dtos);
}