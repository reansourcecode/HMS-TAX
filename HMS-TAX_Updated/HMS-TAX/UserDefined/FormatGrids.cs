using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_TAX.UserDefined
{
    internal class FormatGrids
    {
        public void FormatGrid(DataGridView grid)
        {
            Font columnFont = new Font("Cooper", 9F, FontStyle.Bold);
            Font headerFont = new Font("Cooper", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Font cellFont = new Font("Cooper", 14F, FontStyle.Italic, GraphicsUnit.Pixel);

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.ReadOnly = true;
                col.DefaultCellStyle.Font = columnFont;
            }

            grid.ColumnHeadersDefaultCellStyle.Font = headerFont;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

            grid.DefaultCellStyle.Font = cellFont;
            grid.DefaultCellStyle.ForeColor = Color.Black;
        }
        public void SetColumn(DataGridView grid, string columnName, int width, bool readOnly)
        {
            if (grid.Columns.Contains(columnName))
            {
                grid.Columns[columnName].Width = width;
                grid.Columns[columnName].ReadOnly = readOnly;
            }
        }
    }
}
