﻿// CsvParser parser = new();
// parser.Parse();
// parser.PrintNames();

CsvParser parser = new CsvParser();
List<Person> people = parser.Parse();

// Create instance of PeopleReport
PeopleReport report = new PeopleReport();

// Generate and save reports
report.SaveMales(people.ToArray(), "males.csv");
report.SaveAdultFemales(people.ToArray(), "adultfemales.csv");
report.SaveDotComUsers(people.ToArray(), "dotcomusers.csv");