namespace GsmFactory.ReportCreators
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using CommonResources;
    using iTextSharp.text;
    using iTextSharp.text.pdf;

    public class PdfReportCreator : ReportCreator
    {
        private const string DateTimeFormat = "dd.MM.yyyy";
        private int TableColumnsNumber;
        private readonly List<string> attributes;
        private readonly List<object> reportEntities;

        public PdfReportCreator()
        {
            this.reportEntities = new List<object>();
            this.attributes = new List<string>();
            this.fileExtention = ".pdf";
        }

        public override string CreateReportEntry<T>(T item)
        {
            this.reportEntities.Add(item);
            if (this.objectType == null)
            {
                this.objectType = item.GetType().ToString().Split('.')[2];
                this.TableColumnsNumber = item.GetType().GetProperties().Count();
            }

            if (!this.attributes.Any())
            {
                var properties = item.GetType().GetProperties().Select(x => x.ToString());
                foreach (var prop in properties)
                {
                    var segments = prop.Split(' ');
                    this.attributes.Add(segments[segments.Length - 1]);
                }
            }

            return Constants.successfullCreationOfReports;
        }

        public override string SaveReport(string path)
        {
            try
            {
                this.ExportEntriesToPdf(path, this.objectType + "Report" + this.fileExtention, DateTime.Now);
                return Constants.successfullSaveOfReports;
            }
            catch (Exception ex)
            {
                return ex.StackTrace;
            }
        }

        public void ExportEntriesToPdf(string pathToSave, string pdfReportName, DateTime startDate)
        {
            if (!string.IsNullOrEmpty(pdfReportName))
            {
                Helper.CreateDirectoryIfUnexistant(pathToSave);
            }

            var doc = this.InitializePdfDocument(pathToSave + pdfReportName);
            using (doc)
            {
                doc.Open();
                var table = this.InitializePdfTable(TableColumnsNumber);

                this.SetTableTitle(table, new Font(), TableColumnsNumber, startDate);

                this.FillPdfTableBody(this.reportEntities, table, new Font());

                doc.Add(table);
            }
        }

        // Fill pdf table body with the data queried from the database
        /// <summary>
        /// </summary>
        private void FillPdfTableBody(List<object> reportEntries, PdfPTable table, Font normalFont)
        {
            this.SetTableColumnHeaders(table, normalFont);

            foreach (var entry in reportEntries)
            {
                this.InsertCell(entry, normalFont, table);
            }
        }

        private void InsertCell(object entry, Font normalFont, PdfPTable table)
        {
            foreach (var prop in entry.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace.Contains("Models"))
                {
                    this.InsertCell(prop, normalFont, table);
                }
                else
                {
                    var value = prop.GetValue(entry, null);
                    this.AddTableCell(table, normalFont, null, value.ToString());
                }
            }
        }

        private Document InitializePdfDocument(string pdfFullPath)
        {
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(pdfFullPath, FileMode.OpenOrCreate));
            return doc;
        }

        private PdfPTable InitializePdfTable(int columnsNumber)
        {
            var table = new PdfPTable(columnsNumber);
            table.TotalWidth = 500f;
            table.LockedWidth = true;
            float[] widths = Enumerable.Repeat(120f, this.TableColumnsNumber).ToArray();
            table.SetWidths(widths);
            return table;
        }

        private void SetTableTitle(PdfPTable table, Font font, int tableColumnsNumber, DateTime startDate)
        {
            var cell = new PdfPCell(new Phrase(string.Format("GSM Factory Report ({0})",
                startDate.ToString(DateTimeFormat))));

            cell.Colspan = tableColumnsNumber;
            cell.HorizontalAlignment = 1;
            cell.BackgroundColor = new BaseColor(189, 215, 238);
            cell.PaddingTop = 10f;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);
        }


        private void SetTableColumnHeaders(PdfPTable table, Font font)
        {
            var baseColor = new BaseColor(221, 235, 247);

            foreach (var attribute in this.attributes)
            {
                this.AddTableCell(table, font, baseColor, attribute);
            }
        }

        private void AddTableCell(PdfPTable table, Font font, BaseColor baseColor, string phraseName)
        {
            var cell = new PdfPCell(new Phrase(phraseName, font));
            cell.Colspan = 1;
            cell.HorizontalAlignment = 1;
            cell.BackgroundColor = baseColor;
            cell.PaddingBottom = 5f;
            cell.PaddingLeft = 5f;
            table.AddCell(cell);
        }
    }
}