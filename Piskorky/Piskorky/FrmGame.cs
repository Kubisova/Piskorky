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
        public int Row { get; private set; }
        public int Col { get; private set; }
        public Game Game { get; set; }

        public FrmGame()
        {
            InitializeComponent();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            //FrmAddNewGame frm = new FrmAddNewGame();
            //frm.ShowDialog();
            //frm.Dispose();

            using (var frmAddNewGame = new FrmAddNewGame(this))
            {
                frmAddNewGame.ShowDialog();
            }
        }

        public void StartGame(int rows, int cols, int signs)
        {
            Game = new Game(rows, cols, signs);

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = Game.Cols;
            dataGridView1.RowCount = Game.Rows;

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.Width = dataGridView1.Rows[0].Height;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Row = e.RowIndex;
            Col = e.ColumnIndex;
            if (Game.Playground[Row,Col]=='\0')
            {
                Game.MarkTheSign(Row, Col);
                dataGridView1[Col, Row].Value = Game.Player;

                Game.PutAsideStep(Row, Col, Game.playerIndex);

                bool isWinner = Game.EvaluateTheGame();
                if (isWinner == true)
                {
                    MessageBox.Show($"Vitaz je hrac s {Game.Player}!");
                }
            }
            
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            Game.PreparePlaygroundForSaving(); 
            DataLayer dataLayer = new DataLayer();
            dataLayer.SaveGame(Game);
            MessageBox.Show("Hra bola ulozena.");
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            DataLayer dataLayer = new DataLayer();
            dataGridView1.Rows.Clear();

            var game = dataLayer.LoadGame();

            dataGridView1.ColumnCount = game.Cols;
            dataGridView1.RowCount = game.Rows;

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.Width = dataGridView1.Rows[0].Height;
            }

            game.LoadPlaygroundFromList();
            game.SetSteps();

            for (int i = 0; i < game.Rows; i++)
            {
                for (int j = 0; j < game.Cols; j++)
                {
                    dataGridView1[j, i].Value = game.Playground[i, j];
                }
            }

            Game = game;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Game.TheStepBack();

            for (int i = 0; i < Game.Rows; i++)
            {
                for (int j = 0; j < Game.Cols; j++)
                {
                    dataGridView1[j, i].Value = Game.Playground[i, j];
                }
            }
        }
    }
}
