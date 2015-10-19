namespace GsmFactory.JsonReport
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Runtime.Remoting.Services;
    using System.Text;
    using CommonResources;
    using Newtonsoft.Json;

    public class JsonReportCreator : ReportCreator
    {
        

        public JsonReportCreator()
        {
            this.productsReportsEntries = new List<string>();
            this.fileExtention = ".json";
            this.folderExtention = "Json-Reports";
        }

        public override string CreateReport<T>(T item)
        {
            try
            {
                this.objectType = item.GetType().ToString().Split(new char[] { '.' })[1];
                this.productsReportsEntries.Add((JsonConvert.SerializeObject(item, Formatting.Indented,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects })));

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
                foreach (string reportEntry in this.productsReportsEntries)
                {
                    string fileName = this.productsReportsEntries.IndexOf(reportEntry) + 1 + this.fileExtention;
                    using (
                        StreamWriter jsonReportFile = new StreamWriter(string.Format("{0}\\{1}", path, fileName), true))
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