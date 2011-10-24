using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EQLPROCLib;
using HcTLB;
using ADODB;
using System.Windows.Forms;

namespace Compas.CashRegisters
{
    public class CashRegisterMiniFP//:// ICashRegisterInterface
    {
        //стрічка підключення до реєстратора
        private ADODB.Connection connection;
        //процедурний інтерфейс
        private IEQLProcedure proc;
        //Загальні операції по фіскальному принтеру
        IHcFReg fp;
        //Операції по позиції в чеку
        IHcFRegEx fpext;
        IHcReport report;
        IHcDisplay display;
        IHcFiscPrnt fiscPrinter;
        HcTLB.IHmLastInfo fiscPrinterLastInfo;
        IHcSound fiscPrinterSound;
        //Дані службової таблиці
        ADODB.Recordset srv;

        public CashRegisterMiniFP()
        { }

        #region connections

        /// <summary>
        /// Підключення до Касового Апарату
        /// Number
//Номер аппарата.
//Тип: строка
//Умолчание: "1"
//Позволяет указать кассовый аппарат для работы в виде:
//Логический номер (в виде "число")
//Комбинация номер порта, сетевой номер кассы (в виде "порт;сетевойномер")
//Комбинация номер порта, сетевой номер кассы, скорость обмена (в виде "порт;сетевойномер;скорость")
//Если в момент установки значения свойства сеанс связи с аппаратом был установлен, он закрывается.
//При использовании логического номера он должен совпадать с логическим номером, запрограммированным в кассе в параметрах связи с компьютером.
//Если используется сетевой номер, то он должен совпадать с сетевым номером, запрограммированным в кассе в параметрах связи с компьютером.
//Возможные значения скорости: 9600, 19200, 38400, 57600, 115200. Однако некоторые модели касс не поддерживают скорости 57600 и 115200. Указанная скорость должна совпадать со скоростью обмена с компьютером, запрограммированной в кассе.
//Если касса подключена к компьютеру и в её настройках разрешён обмен с компьютером, то с помощью утилиты comtest.exe вы можете выяснить, на какой скорости работает касса, какой протокол она использует для обмена (упрощённый или полный) и какой имеет сетевой номер. Эти данные помогут вам правильно сформировать строку для свойства Number. Иконка comtest.exe устанавливается на рабочем столе Windows большинством инсталляторов, которые устанавливают драйверы EQL..
        /// </summary>
        public void Connect(string Port, string LogicNumber, string UserId, string Password)
        {
            connection = new Connection();
            string strCnn = "Provider=EQL OLE DB Provider;";
            strCnn = strCnn + "Data Source='" + Port + ";" + LogicNumber + "'";
            //strCnn = strCnn + "Data Source=’" + Port + ";" + LogicNumber + "’";
            strCnn = strCnn + ";User Id=" + UserId + ";Password=" + Password+";";
            strCnn = strCnn + "Extended Properties = \"Protocol=" + "L2Com.HcComSessionCreator\"";
            connection.Open(strCnn);

            srv = new Recordset();
            //відкриття службової таблиці
            srv.Open("EQL_service", connection, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, 512);
            //отримання процедурного інтерфейсу
            proc = srv.Fields[1].Value;
            fp = (IHcFReg)proc;
            fpext = (IHcFRegEx)proc;
            report = (IHcReport)proc;
            display = (IHcDisplay)proc;
            fiscPrinter = (IHcFiscPrnt)proc;
            fiscPrinterLastInfo = (IHmLastInfo)proc;
            fiscPrinterSound = (IHcSound)proc;

            this.OutTone(1000, 100);
        }

        #endregion
        /// <summary>
        /// Почати зміну
        /// </summary>
        public void StartShift()
        {
            fp.SmenBegin();
        }

        /// <summary>
        /// Закрити зміну
        /// </summary>
        public void EndShift()
        {
            
        }


        /// <summary>
        /// Почати чек
        /// </summary>
        public void StartCheck() 
        {
           
            fp.BegChk();
        }

        ///// <summary>
        ///// Почати видатковий чек
        ///// </summary>
        //public void StartReturnCheck()
        //{
        //    fp.();
        //}

        /// <summary>
        /// Закрити чек
        /// </summary>
        public void EndCheck() 
        {
            fp.EndChk();
        }

        /// <summary>
        /// Скасування операцій
        /// </summary>
        public void CancelCheck()
        {
            fp.VoidChk();
        }

        

        /// <summary>
        /// Відключення від Касового Апарату
        /// </summary>
        public void Disconnect() 
        {
            
            srv.Close();
            
        }

        public void CheckConnection()
        {
            try
            {
                MessageBox.Show(Convert.ToString(srv.Fields["ON"].Value));
            }
            catch { }
        }
        /// <summary>
        /// звіт 
        /// </summary>
        public void PrintReport(int ReportTypeID) 
        {

            report.PrintReport(ReportTypeID);
        }


        /// <summary>
        /// додати позицію в чек
        /// </summary>
        public void AddCheckPosition(int Code, decimal PriceForUnit, decimal Quantity, string WareName) 
        {
            fpext.FullProd(Code, PriceForUnit, Quantity, 1, 1, 1, WareName);
        }

        /// <summary>
        /// відмінити останню операцію
        /// </summary>
        public void CancelLastCheckOperation()
        {
            fp.VoidLast();
            
        }

        /// <summary>
        /// відмінити операцію
        /// </summary>
        public void CancelCheckOperation(int WareID)
        {
            fp.VoidProd(WareID);
        }

        /// <summary>
        /// Оплата чеку
        /// </summary>
        /// <param name="Sum"></param>
        public void AddPayment(decimal Sum)
        {
            fp.Oplata(0, Sum, 0);
        }

        /// <summary>
        /// Додати коментар
        /// </summary>
        /// <param name="Comment"></param>
        public void SetTextComment(string Comment)
        {
            fp.TextComment(Comment);
        }

        

        public void DeleteAllWares()
        { 
            
        }

        /// <summary>
        /// Виведення стрічки на індикатор
        /// </summary>
        /// <param name="Text"></param>
        public void DisplayText(string Text)
        {
            display.OutScr(1, Text);
        }

        public void OutTone(int Length, int Tone)
        {
            fiscPrinterSound.OutTone(Length, Tone);
        }

        /// <summary>
        /// Копія останнього чеку
        /// </summary>
        public void CopyLastCheck()
        {
            fp.CopyChk();
        }

        /// <summary>
        /// Друк коментарю
        /// </summary>
        /// <param name="Text"></param>
        public void TextComment(string Text)
        {
            fp.TextComment(Text);
        }

        /// <summary>
        /// Службові внесення і видача грошей у касу. Якщо сума менше 0 - видача, інакше - внесення
        /// </summary>
        /// <param name="Suma"></param>
        public void MoneyInOut(decimal Suma)
        {
            fp.InOut(0, Suma);
        }

        /// <summary>
        /// Відкрити сейф
        /// </summary>
        public void OpenSafe()
        {
            fiscPrinter.OpenSafe();
        }

        /// <summary>
        /// Інформація по останньому чеку
        /// </summary>
        /// <returns></returns>
        public Check LastCheckInfo()
        { 
            object total;
            object number;
            object date;
            object time;
            object operNumber;
            fiscPrinterLastInfo.LastChkInfo(out total, out number, out date, out time, out operNumber);
            Check check = new Check(Convert.ToDecimal(total), number.ToString(), date.ToString(), time.ToString(), operNumber.ToString());
            return check;
        }

    }
}
