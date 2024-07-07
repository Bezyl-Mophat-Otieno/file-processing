using MediatR;

namespace file_processing;

public class ProcessingCsvCommand:IRequest<string>
{
   public IFormFile File { get; set; } = null!;
}
