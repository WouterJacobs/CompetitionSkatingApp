using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CompetitionSkatingApp.Domain.Util
{
    public class DbReader
    {
        public static IDancingEvent LoadDancingEvent(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Read all lines from the file
                    string[] lines = File.ReadAllLines(filePath);

                    // Join lines except the first one (skipping the first line)
                    string jsonString = string.Join(Environment.NewLine, lines.Skip(1));

                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        Converters =
                        {
                            new InterfaceConverter<IEventLocation, EventLocation>(),
                            new InterfaceConverter<IEventSchool, EventSchool>(),
                            new InterfaceConverter<IEventTeam, EventTeam>(),
                            new InterfaceConverter<IEventCoordinator, EventCoordinator>(),
                            new InterfaceConverter<IAddress, Address>(),
                            new InterfaceConverter<ICompetition, Competition>(),
                            new InterfaceConverter<ICouple, Couple>(),
                            new InterfaceConverter<IPerson, EventCoordinator>(), // Assuming EventCoordinator is used for Person
                            new OfficialConverter() // Custom converter for IOfficial
                        }
                    };

                    // Deserialize JSON into DancingEvent object
                    return JsonSerializer.Deserialize<DancingEvent>(jsonString, options);
                }
                else
                {
                    Console.WriteLine($"File '{filePath}' not found.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error loading file: {e.Message}");
            }
            return null;
        }
    }
}
