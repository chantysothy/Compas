using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Reports

{
    public class ReportsLogic
    {

        private CompasDataContext context;

        public ReportsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        #region WaresReports

        public IEnumerable<ViewWaresDetalisation> GetWaresReport(DateTime StartDate, DateTime? EndDate, bool Input, bool Output)
        {
            IEnumerable<ViewWaresDetalisation> result = from a in context.ViewWaresDetalisations
                                                        where a.Date >= StartDate & (a.Date < EndDate || EndDate == null)
                                                        & a.Input == Input & a.Output == Output
                                                        select a;
            return result;
        }

        public IEnumerable<ViewPayment> GetPaymentsReport(DateTime StartDate, DateTime EndDate, int? DocumentTypeID, int? PaymentTypeID, int? StructureObjectID)
        {
            IEnumerable<ViewPayment> result = from a in context.ViewPayments
                                                        where a.Date >= StartDate & a.Date < EndDate
                                                        & (DocumentTypeID == null || (DocumentTypeID != null & a.DocumentTypeID == DocumentTypeID))
                                                        & (PaymentTypeID == null || (PaymentTypeID != null & a.PaymentTypeID == PaymentTypeID))
                                                         & (StructureObjectID == null || (StructureObjectID != null & a.StructureObjectID == StructureObjectID))
                                                         & a.Active == true
                                                        orderby a.Date
                                                        select a;
            return result;
        }


        #endregion


    }
}
