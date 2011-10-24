using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compas.CashRegisters
{
    /// <summary>
    /// перелік підтримуваних моделей фіскальних реєстраторів
    /// </summary>
    public enum CashRegisterModels
    { 
        UNISYSTEM_MINI_FP
    }

    /// <summary>
    /// Клас-фасад для роботи з фіскальними реєстраторами
    /// </summary>
    public class CashRegister //: ICashRegisterInterface
    {
        CashRegisterMiniFP miniFP;
        CashRegisterModels model;

        
        /// <summary>
        /// Підключення до фіскального реєстратора
        /// </summary>
        public void Connect(CashRegisterModels Model, string Port, string LogicNumber, string UserId, string Password)
        {
            model = Model;
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        miniFP = new CashRegisterMiniFP();
                        miniFP.Connect(Port, LogicNumber, UserId, Password);
                        break;
                    }
            }
        }

        /// <summary>
        /// Почати зміну
        /// </summary>
        public void StartShift()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.StartShift();
                        }
                        else
                        { 
                            
                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Закрити зміну
        /// </summary>
        public void EndShift()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.EndShift();
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }
        /// <summary>
        /// Почати чек
        /// </summary>
        public void StartCheck()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.StartCheck();
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Закрити чек
        /// </summary>
        public void EndCheck()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.EndCheck();
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Cкасування операцій
        /// </summary>
        public void CancelCheck()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.CancelCheck();
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }
        /// <summary>
        /// Відключення від Касового Апарату
        /// </summary>
        public void Disconnect()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.Disconnect();
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        #region Reports

        /// <summary>
        /// Х1-звіт
        /// </summary>
        public void GetX1Report()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.PrintReport(10);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Х3-звіт
        /// </summary>
        public void GetX3Report()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.PrintReport(20);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Z1-звіт
        /// </summary>
        public void GetZ1Report()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.PrintReport(0);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Z2-звіт
        /// </summary>
        public void GetZ2Report()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.PrintReport(1);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Z3-звіт
        /// </summary>
        public void GetZ3Report()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.PrintReport(21);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        #endregion Reports

        /// <summary>
        /// Оплата по чеку
        /// </summary>
        /// <param name="Suma"></param>
        public void AddPayment(decimal Suma)
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.AddPayment(Suma);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }
        /// <summary>
        /// Додати позицію в чек
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="PriceForUnit"></param>
        /// <param name="Quantity"></param>
        /// <param name="WareName"></param>
        public void AddCheckPosition(int Code, decimal PriceForUnit, decimal Quantity, string WareName)
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.AddCheckPosition(Code, PriceForUnit, Quantity, WareName);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }
        /// <summary>
        /// Відмінити останню операцію по чеку
        /// </summary>
        /// <param name="WareID"></param>
        public void CanceCheckOperation(int WareID)
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.CancelCheckOperation(WareID);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        public void DeleteAllWares()
        { 
            
        }

        public void DisplayText(string Text)
        {
            miniFP.DisplayText(Text);

        }

        public void CopyLastCheck()
        {
            miniFP.CopyLastCheck();
        }

        public void AddTextComment(string TextComment)
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.TextComment(TextComment);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
            
        }

        public void MoneyInOut(decimal Suma)
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.MoneyInOut(Suma);
                        }
                        else
                        {

                        }
                        break;
                    }
            }

        }

        public void OpenSafe()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.OpenSafe();
                        }
                        else
                        {

                        }
                        break;
                    }
            }

        }

        public void CheckConnection()
        {
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            miniFP.CheckConnection();
                        }
                        else
                        {

                        }
                        break;
                    }
            }

        }

        public Check LastCheckInfo()
        {
            Check check;
            switch (model)
            {
                case CashRegisterModels.UNISYSTEM_MINI_FP:
                    {
                        if (miniFP != null)
                        {
                            check = miniFP.LastCheckInfo();
                            return check;
                        }
                        else
                        {

                        }
                        break;
                    }
            }
            return null;

        }
    }
}
