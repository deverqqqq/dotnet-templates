namespace Template.Service.Implements;

public sealed class SampleService : ISampleService
{
    private readonly ISampleRepository _sampleRepository;
    private readonly ServiceMapper _mapper;

    public SampleService(
        ServiceMapper mapper,
        ISampleRepository sampleRepository)
    {
        this._sampleRepository = sampleRepository;
        this._mapper = mapper;
    }

    public IEnumerable<SampleDto> GetSomeSampleDtos()
    {
        var datas = this._sampleRepository.GetSomeSampleDatas();
        var dtos = this._mapper.MapToSampleDtos(datas);

        return dtos;
    }
}