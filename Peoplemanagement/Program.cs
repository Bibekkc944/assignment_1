string filePath = @"D:\Internship\training\assignment_1\Peoplemanagement\People.csv";

 CSVParser csvParser = new CSVParser();
 csvParser.Parse(filePath);
 csvParser.PrintNames();