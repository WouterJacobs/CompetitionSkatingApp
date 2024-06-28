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
        public void MakeNewDatabaseFile(string eventname)
        {
            StreamWriter writer = null;
            try
            {
                writer = File.CreateText($@"C:\Users\Wouter\Documents\{eventname}.skat");
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
