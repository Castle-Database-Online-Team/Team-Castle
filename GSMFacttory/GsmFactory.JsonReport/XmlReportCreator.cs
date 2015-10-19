using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmFactory.JsonReport
{
    using System.IO;
    using System.Runtime.Serialization;
    using System.Security.AccessControl;
    using System.Xml;
    using System.Xml.Serialization;
    using CommonResources;

    public class XmlReportCreator : ReportCreator
    {

        public XmlReportCreator()
        {
            this.productsReportsEntries = new List<string>();
            this.fileExtention = "report.xml";
        }

        public override string CreateReport<T>(T item)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(item.GetType());
                using (StringWriter sww = new StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create(sww))
                    {
                        serializer.Serialize(writer, item);
                        this.productsReportsEntries.Add(sww.ToString());
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

                foreach (string reportEntry in this.productsReportsEntries)
                {
                    using (
                        StreamWriter xmlReportFile = new StreamWriter(string.Format("{0}\\{1}", path, fileExtention), true))
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
