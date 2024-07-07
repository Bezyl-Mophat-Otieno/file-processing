using MediatR;

namespace file_processing;

public class ProcessingExcelCommand:IRequest<string>
{
    public IFormFile File { get; set; } = null!;

}
