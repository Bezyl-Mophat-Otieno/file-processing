# Excel and CSV File Processing Toolkit

This repository contains a toolkit designed for processing Excel (.xlsx) and CSV files. It demonstrates how to read, manipulate, and export data from these formats using two powerful libraries: CSVHelper for CSV files and NPOI for Excel files. The toolkit is structured to facilitate easy integration into projects that require file processing capabilities.

## Features

- **Reading and Parsing Data**: Efficiently read and parse data from Excel and CSV files.
- **Data Manipulation**: Perform various manipulations on the extracted data, such as filtering, sorting, and transforming.
- **Exporting Data**: Export processed data back into Excel or CSV formats.

## Libraries Used

### CSVHelper

- **Website**: https://joshclose.github.io/CsvHelper/
- **GitHub**: https://github.com/JoshClose/CsvHelper
- **Description**: CsvHelper is a powerful and flexible library for reading and writing CSV files in .NET. It handles everything from reading and writing custom objects to mapping data between objects and CSV records.

### NPOI

- **Website**: http://npoi.net/
- **GitHub**: https://github.com/dotnetcore/NPOI
- **Description**: NPOI is a .NET library that implements the HSSF (Horrible Spreadsheet Format) and XSSF (XML Spreadsheet Format) specifications for Excel files. It supports both .xls (older Excel format) and .xlsx (Office Open XML format) files.

## Getting Started

To get started with this toolkit, clone the repository and explore the code samples provided. Each sample demonstrates a specific task, such as reading an Excel file, manipulating the data, and exporting it back to a CSV file.

### Prerequisites

- .NET Core SDK (for running the samples)
- An IDE or text editor (Visual Studio, Visual Studio Code, etc.)

### Running the Samples

Navigate to the root directory of the cloned repository and run the following commands to build and execute the samples:

```bash
# Build the solution
dotnet build

# Navigate to the desired sample folder and run the sample
cd SampleName
dotnet run
```

Replace `SampleName` with the name of the sample you wish to run.

## Contributing

Contributions are welcome! Please feel free to submit pull requests or report issues.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

