namespace GsmFactory.ReportCreators
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using CommonResources;
    using Newtonsoft.Json;

    public class JsonReportCreator : ReportCreator
    {
        public JsonReportCreator()
        {
            this.reportsEntries = new List<string>();
            this.fileExtention = ".json";
            this.folderExtention = "Json-Reports";
        }

        public override string CreateReportEntry<T>(T item)
        {
            try
            {
                this.objectType = item.GetType().ToString().Split('.')[1];
                this.reportsEntries.Add((JsonConvert.SerializeObject(item, Formatting.Indented,
                    new JsonSerializerSettings {PreserveReferencesHandling = PreserveReferencesHandling.Objects})));

                return Constants.successfullCreationOfReports;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public override string SaveReport(string path)
        {
            path = Helper.AddExtention(path, this.folderExtention);
            try
            {
                Helper.CreateDirectoryIfUnexistant(path);
                foreach (var reportEntry in this.reportsEntries)
                {
                    var fileName = this.reportsEntries.IndexOf(reportEntry) + 1 + this.fileExtention;
                    using (
                        var jsonReportFile = new StreamWriter(string.Format("{0}\\{1}", path, fileName), true))
                    {
                        jsonReportFile.Write(reportEntry);
                    }
                }
                return Constants.successfullSaveOfReports;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}