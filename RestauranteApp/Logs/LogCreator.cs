using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Logs
{
    public class LogCreator
    {
        private string Path = "";

        public LogCreator(string Path)
        {
            this.Path = Path;
        }

        private void CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }
                    
            }
            catch (DirectoryNotFoundException error)
            {
                throw new Exception(error.Message);

            }
        }

        public void AddLog(string LogData)
        {   
            CreateDirectory();
            string FileName = CreateNameFile();
            string MessageLog = DateTime.Now + "__" + LogData + Environment.NewLine;

            StreamWriter stream = new StreamWriter(Path+"/"+FileName,true);
            stream.Write(MessageLog);
            stream.Close();
        }

        private string CreateNameFile()
        {
            string FileName = "";
            FileName = "log_data_" + DateTime.Now.Year + "_" + DateTime.Now.Month + ".log";
            return FileName;
        }
           
    }
}
