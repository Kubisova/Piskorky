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
    public partial class FrmAddNewGame : Form
    {
        public FrmGame FrmGame { get; set; }

        public FrmAddNewGame(FrmGame frmgame)
        {
            InitializeComponent();
            FrmGame = frmgame;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            {
                var rows = int.Parse(txtDimensions.Text);
                var cols = int.Parse(txtDimensions.Text);
                var signs = int.Parse(txtNumberOfSigns.Text);
                FrmGame.StartGame(rows, cols, signs);
                Close();
            }
        }
    }
}
