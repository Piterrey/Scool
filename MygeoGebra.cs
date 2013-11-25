using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGeogebra
{
    public partial class frmMain : Form
    {
        String function = "";
        public frmMain()
        {
            InitializeComponent();
            
        }
        //disegna la griglia quando viene attivata
        private void chbGriglia_CheckedChanged(object sender, EventArgs e)
        {
            DrawGrid();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            grpMain._drawAxis(new Pen(Color.Black));
        }


        //disegna le funzioni inserite
        private void btnFx_Click(object sender, EventArgs e)
        {
            try
            {
                grpMain._drawFunction(txtFx.Text, 100, new Pen(Color.Black));
                function = txtFx.Text;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        //cancella tutte le funzioni
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            grpMain._clearAll();
            grpMain._drawAxis(new Pen(Color.Black));
            DrawGrid();
        }
        //metodo di disegno della griglia 
        public void DrawGrid()
        {
            if (chbGriglia.Checked == true)
            {
                grpMain._drawGridFixed(1, 1, new Pen(Color.LightGray));
            }
            else
            {
                grpMain._drawGridFixed(1, 1, new Pen(Color.White));
                grpMain._drawAxis(new Pen(Color.Black));
            }
        //metodo per tabella Newton

        }

        private void buttonDicotomica_Click(object sender, EventArgs e)
        {
            
            int A = Convert.ToInt32(textboxRegexA.TextBoxRegex);
            int B = Convert.ToInt32(textboxRegexB.TextBoxRegex);
            int C = (A+B)/2;
            int fA = 0;
            int fB = 0;
            int fC = 0;

            int nCicli = 5;
            for (int i = 0; i < nCicli; i++)
            {
                
            }
        }
    }
}


