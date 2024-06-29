using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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

        public void MakeNewDatabaseFile(string eventname)
        {
            StreamWriter writer = null;
            try
            {
                writer = File.CreateText($@"{_filesLocation}\{eventname}.skat");
                writer.WriteLine($"Database for {eventname}");
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
