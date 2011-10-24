//---------------------------------------------------------------------
//  Copyright (C) Microsoft Corporation.  All rights reserved.
// 
//THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
//KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//PARTICULAR PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace DataGridViewAutoFilter
{
    /// <summary>
    /// Represents a DataGridViewComboBoxColumn with a drop-down filter list accessible from the header cell.  
    /// </summary>
    public class DataGridViewAutoFilterComboBoxColumn : DataGridViewComboBoxColumn
    {
        /// <summary>
        /// Initializes a new instance of the DataGridViewAutoFilterTextBoxColumn class.
        /// </summary>
        public DataGridViewAutoFilterComboBoxColumn()
            : base()
        {
            base.DefaultHeaderCellType = typeof(DataGridViewAutoFilterColumnHeaderCell);
            base.SortMode = DataGridViewColumnSortMode.Programmatic;
        }

        #region public properties that hide inherited, non-virtual properties: DefaultHeaderCellType and SortMode

        /// <summary>
        /// Returns the AutoFilter header cell type. This property hides the 
        /// non-virtual DefaultHeaderCellType property inherited from the 
        /// DataGridViewBand class. The inherited property is set in the 
        /// DataGridViewAutoFilterTextBoxColumn constructor. 
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Type DefaultHeaderCellType
        {
            get
            {
                return typeof(DataGridViewAutoFilterColumnHeaderCell);
            }
        }

        /// <summary>
        /// Gets or sets the sort mode for the column and prevents it from being 
        /// set to Automatic, which would interfere with the proper functioning 
        /// of the drop-down button. This property hides the non-virtual 
        /// DataGridViewColumn.SortMode property from the designer. The inherited 
        /// property is set in the DataGridViewAutoFilterTextBoxColumn constructor.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false)]
        [DefaultValue(DataGridViewColumnSortMode.Programmatic)]
        public new DataGridViewColumnSortMode SortMode
        {
            get
            {
                return base.SortMode;
            }
            set
            {
                if (value == DataGridViewColumnSortMode.Automatic)
                {
                    throw new InvalidOperationException(
                        "A SortMode value of Automatic is incompatible with " +
                        "the DataGridViewAutoFilterColumnHeaderCell type. " +
                        "Use the AutomaticSortingEnabled property instead.");
                }
                else
                {
                    base.SortMode = value;
                }
            }
        }

        #endregion

        #region public properties: FilteringEnabled, AutomaticSortingEnabled, DropDownListBoxMaxLines

        /// <summary>
        /// Gets or sets a value indicating whether filtering is enabled for this column. 
        /// </summary>
        [DefaultValue(true)]
        public Boolean FilteringEnabled
        {
            get
            {
                // Return the header-cell value.
                return ((DataGridViewAutoFilterColumnHeaderCell)HeaderCell)
                    .FilteringEnabled;
            }
            set
            {
                // Set the header-cell property. 
                ((DataGridViewAutoFilterColumnHeaderCell)HeaderCell)
                    .FilteringEnabled = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether automatic sorting is enabled for this column. 
        /// </summary>
        [DefaultValue(true)]
        public Boolean AutomaticSortingEnabled
        {
            get
            {
                // Return the header-cell value.
                return ((DataGridViewAutoFilterColumnHeaderCell)HeaderCell)
                    .AutomaticSortingEnabled;
            }
            set
            {
                // Set the header-cell property.
                ((DataGridViewAutoFilterColumnHeaderCell)HeaderCell)
                    .AutomaticSortingEnabled = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum height of the drop-down filter list for this column. 
        /// </summary>
        [DefaultValue(20)]
        public Int32 DropDownListBoxMaxLines
        {
            get
            {
                // Return the header-cell value.
                return ((DataGridViewAutoFilterColumnHeaderCell)HeaderCell)
                    .DropDownListBoxMaxLines;
            }
            set
            {
                // Set the header-cell property.
                ((DataGridViewAutoFilterColumnHeaderCell)HeaderCell)
                    .DropDownListBoxMaxLines = value;
            }
        }

        #endregion public properties

        #region public, static, convenience methods: RemoveFilter and GetFilterStatus

        /// <summary>
        /// Removes the filter from the BindingSource bound to the specified DataGridView. 
        /// </summary>
        /// <param name="dataGridView">The DataGridView bound to the BindingSource to unfilter.</param>
        public static void RemoveFilter(DataGridView dataGridView)
        {
            DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dataGridView);
        }

        /// <summary>
        /// Gets a status string for the specified DataGridView indicating the 
        /// number of visible rows in the bound, filtered BindingSource, or 
        /// String.Empty if all rows are currently visible. 
        /// </summary>
        /// <param name="dataGridView">The DataGridView bound to the 
        /// BindingSource to return the filter status for.</param>
        /// <returns>A string in the format "x of y records found" where x is 
        /// the number of rows currently displayed and y is the number of rows 
        /// available, or String.Empty if all rows are currently displayed.</returns>
        public static String GetFilterStatus(DataGridView dataGridView)
        {
            return DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dataGridView);
        }

        /// <summary>
        /// Gets the display value of an item based on the provided ICustomTypeDescriptor.
        /// </summary>
        /// <param name="ictd">Custom type descriptor.</param>
        /// <param name="value">Current value of the combo.</param>
        /// <returns>Value of the specified custom type descriptor.</returns>
        public object GetDisplayValue(ICustomTypeDescriptor ictd, object value)
        {
            if (this.DataSource != null)
            {
                object holdValue, holdDisplay;
                if (!string.IsNullOrEmpty(this.DisplayMember))
                {
                    foreach (object o in this.Items)
                    {
                        holdValue = ictd.GetProperties().Find((string.IsNullOrEmpty(this.ValueMember) ? this.DisplayMember : this.ValueMember), true).GetValue(ictd);
                        holdDisplay = ictd.GetProperties().Find((string.IsNullOrEmpty(this.DisplayMember) ? this.ValueMember : this.DisplayMember), true).GetValue(ictd);
                        if (holdValue.Equals(value))
                        {
                            return holdDisplay;
                        }
                    }
                }
            }

            // Return value if we didn't find a match.
            return value;
        }

        /// <summary>
        /// Gets the real value of the combo when supplied with the selected filter value.
        /// </summary>
        /// <param name="selectedFilterValue">Currently selected filter value.</param>
        /// <param name="columnProperty">The column name in a form acceptable to the Filter property.</param>
        /// <returns>The new filter value.</returns>
        public string GetNewFilterValue(string selectedFilterValue, string columnProperty)
        {
            if (this.DataSource != null)
            {
                object holdValue, holdDisplay;
                if (!string.IsNullOrEmpty(this.DisplayMember))
                {
                    foreach (object o in this.Items)
                    {
                        ICustomTypeDescriptor ictd = o as ICustomTypeDescriptor;
                        holdValue = ictd.GetProperties().Find((string.IsNullOrEmpty(this.ValueMember) ? this.DisplayMember : this.ValueMember), true).GetValue(ictd);
                        holdDisplay = ictd.GetProperties().Find((string.IsNullOrEmpty(this.DisplayMember) ? this.ValueMember : this.DisplayMember), true).GetValue(ictd);
                        if (holdDisplay.Equals(selectedFilterValue))
                        {
                            if (holdValue is string)
                            {
                                return string.Format(
                                    "[{0}]='{1}'",
                                    columnProperty,
                                    ((string)holdValue).Replace("'", "''"));
                            }
                            else
                            {
                                return string.Format(
                                    "[{0}]={1}",
                                    columnProperty,
                                    holdValue.ToString());
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (object o in this.Items)
                {
                    if (o.Equals(selectedFilterValue))
                    {
                        if (o is string)
                        {
                            return string.Format(
                                "[{0}]='{1}'",
                                columnProperty,
                                ((string)o).Replace("'", "''"));
                        }
                        else
                        {
                            return string.Format(
                                "[{0}]={1}",
                                columnProperty,
                                o.ToString());
                        }
                    }
                }
            }

            // Return the currently selected filter value if we didn't find a match.
            return selectedFilterValue;
        }

        #endregion
    }
}