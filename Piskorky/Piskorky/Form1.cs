using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piskorky
{
    public partial class FrmGame : Form
    {

        private int _rowIdx;
        private int _colIdx;
        public FrmGame()
        {
            InitializeComponent();

            
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            FrmAddNewGame frm = new FrmAddNewGame();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _rowIdx = e.RowIndex;
            _colIdx = e.ColumnIndex;
            
        }
    }
}
