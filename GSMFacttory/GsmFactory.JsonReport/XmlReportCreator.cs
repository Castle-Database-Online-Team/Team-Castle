namespace GsmFactory.ReportCreators
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;
    using CommonResources;

    public class XmlReportCreator : ReportCreator
    {
        public XmlReportCreator()
        {
            this.reportsEntries = new List<string>();
            this.fileExtention = "report.xml";
        }

        public override string CreateReportEntry<T>(T item)
        {
            try
            {
                var serializer = new XmlSerializer(item.GetType());
                using (var sww = new StringWriter())
                {
                    using (var writer = XmlWriter.Create(sww))
                    {
                        serializer.Serialize(writer, item);
                        this.reportsEntries.Add(sww.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


            /*XmlSerializer xsSubmit = new XmlSerializer(typeof(MyObject));
             var subReq = new MyObject();
             using(StringWriter sww = new StringWriter())
             using(XmlWriter writer = XmlWriter.Create(sww))
             {
                 xsSubmit.Serialize(writer, subReq);
                 var xml = sww.ToString(); // Your XML
             }*/
            return Constants.successfullCreationOfReports;
        }

        public override string SaveReport(string path)
        {
            try
            {
                Helper.CreateDirectoryIfUnexistant(path);

                foreach (var reportEntry in this.reportsEntries)
                {
                    using (
                        var xmlReportFile = new StreamWriter(string.Format("{0}\\{1}", path, this.fileExtention), true))
                    {
                        xmlReportFile.Write(reportEntry);
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