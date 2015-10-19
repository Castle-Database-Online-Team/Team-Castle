namespace GsmFactory.JsonReport
{
    using System.Collections.Generic;
    using System.Text;
    using CommonResources;

    public abstract class ReportCreator
    {
        protected  List<string> productsReportsEntries;
        
        protected string objectType;
        
        protected string fileExtention;
        
        protected string folderExtention;

        public abstract string CreateReport<T>(T item);

        public abstract string SaveReport(string path);

    }
}