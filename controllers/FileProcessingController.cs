using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace file_processing;

[ApiController]
[Route("api/v1/processing/")]
public class FileProcessingController: ControllerBase
{
    private readonly IMediator _mediator;

    public FileProcessingController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("csv")]
        public async Task<IActionResult> ProcessingCsv([FromForm] ProcessingCsvCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
    [HttpPost]
    [Route("excel")]

    public async Task<IActionResult> ProcessingExcel([FromForm] ProcessingExcelCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

}
