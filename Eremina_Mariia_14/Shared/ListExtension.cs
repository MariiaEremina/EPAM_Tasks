using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class ListExtension
    {
        public static DataTable ToDataTable<T>(this List<T> spisok)
        {
            if (spisok.Count != 0)
            {
                var properties = spisok[0].GetType().GetProperties();
                DataTable table = new DataTable("Smad");
                DataColumn col;
                DataRow row;
                foreach (var pr in properties)
                {
                    col = new DataColumn(pr.Name, Type.GetType(pr.PropertyType.FullName));
                    table.Columns.Add(col);
                }
                foreach (var element in spisok)
                {
                    row = table.NewRow();

                    foreach (DataColumn colum in table.Columns)
                    {
                        //row[i] =(dynamic)element+""
                        row[colum.ColumnName] = element.GetType().GetProperty(colum.ColumnName).GetValue(element, null);
                    }
                    table.Rows.Add(row);
                }
                return table;
            }
            return null;
        }
    }
}

