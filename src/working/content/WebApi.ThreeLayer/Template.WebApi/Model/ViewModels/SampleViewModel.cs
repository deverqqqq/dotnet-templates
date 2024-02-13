namespace Template.WebApi.Model.ViewModels;

public class SampleViewModel
{
    public string ColumnA { get; set; }
    public string ColumnB { get; set; }
    public int ColumnC { get; set; }
    public IEnumerable<SampleDetailViewModel> Details { get; set; }
}

public class SampleDetailViewModel
{
    public string DetailInfoA { get; set; }
    public string DetailInfoB { get; set; }
    public decimal DetailInfoC { get; set; }
}