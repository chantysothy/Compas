using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compas.CashRegisters
{
    public interface ICashRegisterInterface
    {
        int Description
        {
            get;
            set;
        }

        /// <summary>
        /// Підключення до Касового Апарату
        /// </summary>
        void Connect();


        /// <summary>
        /// Почати чек
        /// </summary>
        void StartCheck();

        /// <summary>
        /// Закрити чек
        /// </summary>
        void EndCheck();

        /// <summary>
        /// Відключення від Касового Апарату
        /// </summary>
        void Disconnect();

        /// <summary>
        /// Х-звіт
        /// </summary>
        void GetXReport();

        /// <summary>
        /// Z-звіт
        /// </summary>
        void GetZReport();

        /// <summary>
        /// почати зміну
        /// </summary>
        void StartShift();


        void AddCheckPosition();
        void RemoveCheckPosition();

        void AddPayment();
    }
}
