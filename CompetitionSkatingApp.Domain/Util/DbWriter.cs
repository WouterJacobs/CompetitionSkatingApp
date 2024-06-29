using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain.Util
{
    public class DbWriter
    {
        private string _filesLocation;

        public DbWriter()
        {
            _filesLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public void MakeNewDatabaseFile(IDancingEvent dancingEvent)
        {
            StreamWriter writer = null;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            try
            {
                writer = File.CreateText($@"{_filesLocation}\{dancingEvent.Name}.skat");
                writer.WriteLine($"Database for {dancingEvent.Name}");
                writer.WriteLine(JsonSerializer.Serialize(dancingEvent, options));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                writer?.Close();
            }
        }
    }
}
