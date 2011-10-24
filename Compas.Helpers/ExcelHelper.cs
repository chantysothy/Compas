using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
//using Ionic;

namespace Compas.Helpers
{
    public class ExcelHelper
    {
       

            private Sheet _currentSheet;
            HSSFWorkbook _hssfworkbook;
            public ExcelHelper CreateFile(string sheetSubject = "")
            {
                _hssfworkbook = new HSSFWorkbook();
                ////create a entry of DocumentSummaryInformation
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
                dsi.Company = "Algorhythm Tech Pvt Ltd";
                _hssfworkbook.DocumentSummaryInformation = dsi;

                //////create a entry of SummaryInformation
                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Subject = sheetSubject;
                _hssfworkbook.SummaryInformation = si;
                return this;
            }
            public ExcelHelper CreateSheet(string sheetName = "Sheet1")
            {
                _currentSheet = _hssfworkbook.CreateSheet(sheetName);
                return this;
            }
            public ExcelHelper WriteSave(string filePath)
            {
                if (File.Exists(filePath)) File.Delete(filePath);
                FileStream file = new FileStream(filePath, FileMode.Create);
                _hssfworkbook.Write(file);
                file.Close();
                return this;
            }
            public ExcelHelper GetSheet(string name)
            {
                _currentSheet = _hssfworkbook.GetSheet(name);
                return this;
            }
            private Row _row;
            public NPOI.SS.UserModel.Row CreateRow(int rownum)
            {
                _row = CurrentSheet.CreateRow(rownum);
                return _row;
            }
            private NPOI.SS.UserModel.Cell _cell;
            public ExcelHelper CreateCell(int cellnum)
            {
                _cell = _row.CreateCell(cellnum);
                return this;
            }
            public ExcelHelper SetCellValue(string val)
            {
                _cell.SetCellValue(val);
                return this;
            }
            public ExcelHelper SetCellValue(DateTime val)
            {
                _cell.SetCellValue(val);
                return this;
            }
            public ExcelHelper SetCellValue(double val)
            {
                _cell.SetCellValue(val);
                return this;
            }
            public ExcelHelper SetCellValue(RichTextString val)
            {
                _cell.SetCellValue(val);
                return this;
            }
            public ExcelHelper SetCellValue(bool val)
            {
                _cell.SetCellValue(val);
                return this;
            }
            public Row CurrentRow { get { return _row; } }
            public NPOI.SS.UserModel.Cell CurrentCell { get { return _cell; } }
            public CellStyle CurrentCellStyle
            {
                get { return _cellStyle; }
            }

            public Sheet CurrentSheet
            {
                get { return _currentSheet; }
            }

            private CellStyle _cellStyle;
            /// <summary>
            /// <example>
            /// <b>// we style the second cell as a date (and time). It is important to Create a new cell style from the workbook
            /// // otherwise you can end up modifying the built in style and effecting not only this cell but other cells.
            /// </b>
            /// CellStyle cellStyle = hssfworkbook.CreateCellStyle();
            /// 
            /// // Perhaps this may only works for Chinese date, I don't have english office on hand
            /// // cellStyle.DataFormat = hssfworkbook.CreateDataFormat().GetFormat("[$-409]h:mm:ss AM/PM;@");
            /// 
            /// cell.CellStyle=cellStyle;
            /// </example>
            /// </summary>
            /// <returns></returns>
            public ExcelHelper CreateCellStyle()
            {
                _cellStyle = _hssfworkbook.CreateCellStyle();
                return this;
            }

            public ExcelHelper OpenExcelFile(string filePath)
            {
                _hssfworkbook = new HSSFWorkbook(OpenFileStream(filePath));
                _currentSheet = _hssfworkbook.GetSheetAt(0);
                _row = CurrentSheet.GetRow(0);
                _cell = _row.GetCell(0);
                return this;
            }

            public ExcelHelper GetCell(int col, int row)
            {
                _row = CurrentSheet.GetRow(row);
                _cell = _row.GetCell(col);
                return this;
            }

            private Stream OpenFileStream(string filePath)
            {
                return new FileStream(filePath, FileMode.Open);
            }
            public ExcelHelper SetRowHeight(short height)
            {
                _row.Height = height;
                return this;
            }
            public ExcelHelper SetColWidth(short col, int width)
            {
                CurrentSheet.SetColumnWidth(col, width);
                return this;
            }
            public string GetStringTex(int col, int row)
            {
                return _currentSheet.GetRow(row).GetCell(col).StringCellValue;
            }
            public DateTime GetDateTex(int col, int row)
            {
                return _currentSheet.GetRow(row).GetCell(col).DateCellValue;
            }
            public RichTextString GetRichTextTex(int col, int row)
            {
                return _currentSheet.GetRow(row).GetCell(col).RichStringCellValue;
            }
            public double GetdoubleTex(int col, int row)
            {
                return _currentSheet.GetRow(row).GetCell(col).NumericCellValue;
            }
        
    }
}
