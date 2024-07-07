using System.Globalization;
using MediatR;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace file_processing;

public class ProcessingCsvCommandHandler : IRequestHandler<ProcessingCsvCommand, string>
{
    public Task<string> Handle(ProcessingCsvCommand request, CancellationToken cancellationToken)
    {
          var config = new CsvConfiguration();
        config.CultureInfo = CultureInfo.InvariantCulture;
        config.Delimiter = ";";
        config.HasHeaderRecord = true;
        config.AutoMap<UserCsv>();
        using var reader = new StreamReader(request.File.OpenReadStream());
        using var csv = new CsvReader(reader, config);
        var records = csv.GetRecords<UserCsv>().ToList();
        var jsonContent = JsonConvert.SerializeObject(records);
        return Task.FromResult(jsonContent);
    }
}
