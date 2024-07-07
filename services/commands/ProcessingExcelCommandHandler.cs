using System.Globalization;
using MediatR;
using Newtonsoft.Json;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace file_processing;

public class ProcessingExcelCommandHandler : IRequestHandler<ProcessingExcelCommand, string>
{
    private const int HeaderRowCount = 1;
    public async Task<string> Handle(ProcessingExcelCommand request, CancellationToken cancellationToken)
    {
        var records = new List<UserExcel>();

        using var stream = new MemoryStream();
        await request.File.CopyToAsync(stream, cancellationToken);
        stream.Position = 0; // Reset the stream position to the beginning

        using var workbook = new XSSFWorkbook(stream);
        var sheet = workbook.GetSheetAt(0); // Assuming you're working with the first sheet

        var rowCount = sheet.LastRowNum;
        for (int rowIndex = HeaderRowCount + 1; rowIndex <= rowCount; rowIndex++)
        {
            var row = sheet.GetRow(rowIndex);
            if (row != null && row.Cells.Any())
            {
                var user = CreateUserFromRow(row);
                records.Add(user);
            }
        }

        // Serialize the records to JSON
        var jsonContent = JsonConvert.SerializeObject(records);

        // Instead of writing to a file, return the JSON content as a string
        return jsonContent;
    }

    private UserExcel CreateUserFromRow(IRow row)
    {
     return new UserExcel
        {
            FirstName = row.GetCell(0)?.ToString() ?? "",
            LastName = row.GetCell(1)?.ToString() ?? "",
            Gender = row.GetCell(2)?.ToString() ?? "",
            Country = row.GetCell(3)?.ToString() ?? "",
            Age = int.TryParse(row.GetCell(4)?.ToString(), out var parsedAge) ? parsedAge : 0,
            Date = DateTime.TryParseExact(row.GetCell(5)?.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate) ? parsedDate : DateTime.MinValue,
            Id = int.TryParse(row.GetCell(6)?.ToString(), out var parsedId) ? parsedId : 0
        };
    }
}
