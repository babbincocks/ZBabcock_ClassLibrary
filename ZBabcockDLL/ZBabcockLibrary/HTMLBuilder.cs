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
            _reportName = "My Report";
            _folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StartReport();
        }

        public HTMLReportBuilder(string fileName)
        {
            _reportName = fileName;
            _folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StartReport();
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
            StartReport();
        }

        private void StartReport()
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

        private void AddTable(List<string> columnTitles, Queue<string> contents)
        {
            int rowTrack = 1;
            if(contents.Count % columnTitles.Count == 0)
            {
                _qBody.Enqueue("<table>");
                _qBody.Enqueue("<tr>");
                foreach (string title in columnTitles)
                {
                    _qBody.Enqueue("<th>" + title + "</th>");

                }
                _qBody.Enqueue("</tr>");

                while (contents.Count > 0)
                {
                    if(rowTrack == 1)
                    {
                        _qBody.Enqueue("<tr>");
                    }

                    _qBody.Enqueue("<td>" + contents.Dequeue() + "</td>");

                    if(rowTrack == columnTitles.Count)
                    {
                        _qBody.Enqueue("</tr>");
                        rowTrack = 1;
                    }
                }
                _qBody.Enqueue("</table>");
            }
            
        }

        public void WriteHTMLToFile()
        {
            StreamWriter swHTML = new StreamWriter(_folder + _reportName + ".html");

            EndReport();

            while(_qHead.Count > 0)
            {
                swHTML.WriteLine(_qHead.Dequeue());
            }

            while(_qBody.Count > 0)
            {
                swHTML.WriteLine(_qBody.Dequeue());
            }

            swHTML.Flush();
            swHTML.Close();
        }
    }
}
