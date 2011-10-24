using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

using System.Globalization;
using System.IO;

using CompletIT.Windows.DataGridViewExtension;
using CompletIT.Windows.Forms.Export.Pdf;
using CompletIT.Windows.Forms.Export.Html;

using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;

namespace Compas.Helpers
{
    

    public class DataGridExport
    {
        public DataGridExport()
        { 
        
        }

        public static void ExportToExcel(DataGridView DataGV, string Name)
        {
            ExcelDocument document = new ExcelDocument();
            document.UserName = "Compas";
            document.CodePage = CultureInfo.CurrentCulture.TextInfo.ANSICodePage;

            document.ColumnWidth(0, 120);
            document.ColumnWidth(1, 80);
            
            document[0, 0].Value = Name;
            document[0, 0].Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
            document[0, 0].ForeColor = ExcelColor.DarkRed;
            document[0, 0].Alignment = Alignment.Centered;
            document[0, 0].BackColor = ExcelColor.Silver;

            int i = 1;//стрічка
            int j = 0;//колонка
            foreach (DataGridViewRow r in DataGV.Rows)
            {
                j = 0;

                foreach (DataGridViewCell c in r.Cells)
                {
                    //document.Cell(i,j).Format
                    
                    document.WriteCell(i, j, c.Value == null ? "" : c.Value.ToString());
                    j++;
                }

                i++;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = Name;
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.ShowDialog();

            FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);

            document.Save(stream);
            stream.Close();

            System.Diagnostics.Process.Start(saveFileDialog1.FileName);
        }

        public static void ExportToExcelExtended(DataTable table, string Name)
        {

            //ExcelHelper excel = new ExcelHelper();
            //excel.CreateFile(Name);
            //excel.CreateSheet(Name);

            InitializeWorkbook();

            Sheet sheet = hssfworkbook.CreateSheet("new sheet");

            //ExcelDocument document = new ExcelDocument();
            //document.UserName = "Compas";
            //document.CodePage = CultureInfo.CurrentCulture.TextInfo.ANSICodePage;

            //document.ColumnWidth(0, 120);
            //document.ColumnWidth(1, 80);

            //document[0, 0].Value = Name;
            //document[0, 0].Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
            //document[0, 0].ForeColor = ExcelColor.DarkRed;
            //document[0, 0].Alignment = Alignment.Centered;
            //document[0, 0].BackColor = ExcelColor.Silver;

            int i = 1;//стрічка
            int j = 1;//колонка
           
            NPOI.SS.UserModel.Row header = sheet.CreateRow(0);

            foreach (DataColumn column in table.Columns)
            {
                NPOI.SS.UserModel.Cell cell = header.CreateCell(j);
                cell.SetCellValue(column.ColumnName);
                j++;
            }

            j = 1;

            foreach (DataRow r in table.Rows)
            {
                j = 1;
                //NPOI.SS.UserModel.Row row = excel.CreateRow(i);
                NPOI.SS.UserModel.Row row = sheet.CreateRow(i);
                foreach(DataColumn column in table.Columns)
                {
                    NPOI.SS.UserModel.Cell cell = row.CreateCell(j);

                    Type dataType = column.DataType;

                    

                    switch (dataType.Name)
                    {
                        case "String":
                            {
                                cell.SetCellValue(r.ItemArray[j - 1].ToString());
                                break;
                            }
                        case "DateTime":
                            {
                                DateTime date = (Convert.ToDateTime(r.ItemArray[j-1]));
                                cell.SetCellValue(date);
                                CellStyle cellStyle = hssfworkbook.CreateCellStyle();
                                cellStyle.DataFormat = hssfworkbook.CreateDataFormat().GetFormat("yyyyy-MM-dd h:mm:ss");
                               
                                cell.CellStyle = cellStyle;

                                
                                break;                                
                            }
                        case "Decimal":
                            {
                                if (r.ItemArray[j - 1] != null)
                                    if(r.ItemArray[j - 1] != null)
                                        if (r.ItemArray[j - 1].ToString().Length>0)
                                            cell.SetCellValue(Convert.ToDouble(r.ItemArray[j - 1]));
                                break;
                            }
                        default:
                            {
                                cell.SetCellValue(r.ItemArray[j - 1].ToString());
                                break;
                            }
                    }
                    //excel.SetCellValue( r.ItemArray[j]
                    j++;
                }
                
                //foreach (object item in r.ItemArray)
                //{
                //    //document.Cell(i,j).Format
                //    excel.CreateCell(j);
                    
                //    excel.SetCellValue( item == null ? "" : (item);
                    
                //    j++;
                //}

                i++;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = Name;
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.ShowDialog();

            //FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);

            WriteToFile(saveFileDialog1.FileName);
            

            //System.Diagnostics.Process.Start(saveFileDialog1.FileName);
        }

        
        static HSSFWorkbook hssfworkbook;

        static void WriteToFile(string FileName)
        {
            //Write the stream data of workbook to the root directory
            FileStream file = new FileStream(FileName, FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
        }

        static void InitializeWorkbook()
        {
            hssfworkbook = new HSSFWorkbook();

            //Create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "NPOI Team";
            hssfworkbook.DocumentSummaryInformation = dsi;

            //Create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "NPOI SDK Example";
            hssfworkbook.SummaryInformation = si;
        }

        public static void ExportToPDF(DataGridView DataGV, string Name)
        {
            DGVEPdfExportSettings exportSettings = new DGVEPdfExportSettings();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = Name;
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.ShowDialog();

            exportSettings.ExportFileName = saveFileDialog1.FileName;//Export file name 
            exportSettings.OpenFileAfterGeneration = true; //Open generated file after export 
            System.Drawing.Printing.PaperSize paper = new System.Drawing.Printing.PaperSize("A4", 1169, 827);
            exportSettings.PdfPaperSize = paper;
           

            //Set other settings here... 
            DGVEPdfExporter exporter = new DGVEPdfExporter();
            exporter.Export(DataGV, exportSettings);
        }

        public static void ExportToHTML(DataGridView DataGV, string Name)
        {
            DGVEHtmlExportSettings exportSettings = new DGVEHtmlExportSettings();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = Name;
            saveFileDialog1.DefaultExt = "html";
            saveFileDialog1.ShowDialog();

            exportSettings.ExportFileName = saveFileDialog1.FileName;//Export file name 

            exportSettings.OpenFileAfterGeneration = true; //Open generated file after export 
            //Set other settings here... 
            DGVEHtmlExporter exporter = new DGVEHtmlExporter();
            exporter.Export(DataGV, exportSettings);
        }


    }
}
