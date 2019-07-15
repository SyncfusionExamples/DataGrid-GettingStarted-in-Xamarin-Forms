using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GettingStarted
{
    public partial class DataGridPage : ContentPage
    {
        public DataGridPage()
        {
            InitializeComponent();

            //GridGroupSummaryRow summaryRow = new GridGroupSummaryRow();
            //summaryRow.Title = "Total Salary:{TotalSalary} for {ProductCount} members";
            //summaryRow.ShowSummaryInRow = true;
            //summaryRow.SummaryColumns.Add(new GridSummaryColumn()
            //{
            //    Name = "TotalSalary",
            //    MappingName = "Salary",
            //    Format = "{Sum:c}",
            //    SummaryType = SummaryType.DoubleAggregate
            //});
            //summaryRow.SummaryColumns.Add(new GridSummaryColumn()
            //{
            //    Name = "ProductCount",
            //    MappingName = "Salary",
            //    Format = "{Count}",
            //    SummaryType = SummaryType.CountAggregate
            //});
            //sfGrid.CaptionSummaryRow = summaryRow;
            //Columns are manually generated instead of auto generating based on model properties.
            //sfGrid.AutoGenerateColumns = false;

            //GridTextColumn orderIdColumn = new GridTextColumn();
            //orderIdColumn.MappingName = "OrderID";
            //orderIdColumn.HeaderText = "Order ID";

            //GridTextColumn customerIdColumn = new GridTextColumn();
            //customerIdColumn.MappingName = "CustomerID";
            //customerIdColumn.HeaderText = "Customer ID";

            //GridTextColumn customerColumn = new GridTextColumn();
            //customerColumn.MappingName = "Customer";
            //customerColumn.HeaderText = "Customer";

            //GridTextColumn countryColumn = new GridTextColumn();
            //countryColumn.MappingName = "ShipCountry";
            //countryColumn.HeaderText = "Country";

            //sfGrid.Columns.Add(orderIdColumn);
            //sfGrid.Columns.Add(customerIdColumn);
            //sfGrid.Columns.Add(customerColumn);
            //sfGrid.Columns.Add(countryColumn);
        }
    }
}