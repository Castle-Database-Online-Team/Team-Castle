namespace GsmFactory.ReportCreators
{
    using System.Collections.Generic;

    public abstract class ReportCreator
    {
        protected string fileExtention;

        protected string folderExtention;

        protected string objectType;
        protected List<string> reportsEntries;

        public abstract string CreateReportEntry<T>(T item);

        public abstract string SaveReport(string path);
    }
}