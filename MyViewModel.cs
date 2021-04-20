using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls;
using System.Data;

namespace GridViewDataTable
{
    public class MyViewModel 
    {
        private DataTable datatable;
        public DataTable DataTable
        {
            get
            {
                if (this.datatable == null)
                {
                    this.datatable = this.CreateDataTable();
                }

                return this.datatable;
            }
        }

        private DataTable CreateDataTable()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add(new System.Data.DataColumn("FirstName", typeof(string)));
            dataTable.Columns.Add(new System.Data.DataColumn("LastName", typeof(string)));
            dataTable.Columns.Add(new System.Data.DataColumn("City", typeof(int)));
            dataTable.Columns.Add(new System.Data.DataColumn("LastTimeUpdate", typeof(DateTime)));

            for (int i = 1; i <= 800; i++)
            {
                var row = dataTable.NewRow();
                row["FirstName"] = "FirstName " + i;
                row["LastName"] = "LastName" + i;
                row["City"] = i;
                row["LastTimeUpdate"] = DateTime.Now;
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
    }
}
