namespace Template.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    private readonly ApplicationMapper _mapper;
    private readonly ISampleService _sampleService;

    public SampleController(
        ApplicationMapper mapper, 
        ISampleService sampleService)
    {
        this._mapper = mapper;
        this._sampleService = sampleService;
    }

    [HttpGet("list")]
    public IEnumerable<SampleViewModel> Get()
    {
        var dtos = this._sampleService.GetSomeSampleDtos();
        var result = this._mapper.MapToSampleViewModels(dtos);

        return result;
    }
}