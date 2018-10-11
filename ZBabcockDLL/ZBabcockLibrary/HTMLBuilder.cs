using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZBabcockLibrary
{
    class HTMLReportBuilder
    {

        private string _folder;
        private string _reportName;
        private Queue<string> _qHead = new Queue<string>();
        private Queue<string> _qBody = new Queue<string>();

        public HTMLReportBuilder()
        {
            _reportName = "";
            _folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            CreateReport();
        }

        public HTMLReportBuilder(string fileName)
        {
            _reportName = fileName;
            _folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            CreateReport();
        }

        public HTMLReportBuilder(string fileName, string folderPath)
        {
            _reportName = fileName;

            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if(Directory.Exists(folderPath))
            {
                if(!folderPath.EndsWith(@"\"))
                {
                    folderPath += @"\";
                }

                _folder = folderPath;
            }
            _folder = folderPath;
            CreateReport();
        }

        private void CreateReport()
        {
            _qHead.Clear();
            _qHead.Enqueue("<!DOCTYPE html>");
            _qHead.Enqueue(@"<html lang=""en"">");
            _qHead.Enqueue("<head>");
            _qHead.Enqueue("<title>" + _reportName + "</title>");

            _qBody.Clear();
            _qBody.Enqueue("<body>");

        }

        private void EndReport()
        {
            _qHead.Enqueue("</head>");

            _qBody.Enqueue("</body>");
            _qBody.Enqueue("</html>");
        }


        private void AddParagraph(string paragraphContents)
        {
            _qBody.Enqueue("<p>" + paragraphContents + "</p>");
        }

        private void AddTable(int columnCount, List<string> columnTitles, string contents)
        {
            if(columnCount == columnTitles.Count)
            {

            }
        }
    }
}
