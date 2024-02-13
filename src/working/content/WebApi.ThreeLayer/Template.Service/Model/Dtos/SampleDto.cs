namespace Template.Service.Model.Dtos;

public class SampleDto
{
    public string ColumnA { get; set; }
    public string ColumnB { get; set; }
    public int ColumnC { get; set; }
    public IEnumerable<SampleDetailDto> Details { get; set; } 
}

public class SampleDetailDto
{
    public string DetailInfoA { get; set; }
    public string DetailInfoB { get; set; }
    public decimal DetailInfoC { get; set; }
}