using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algoritmos_recursividad;
using EDDemo.Estructuras_lineales;
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void pilasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinarySearchForm mBinarySearchForm = new BinarySearchForm();
            mBinarySearchForm.MdiParent = this;
            mBinarySearchForm.Show();
        }

        private void colasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExponentForm mExponentForm = new ExponentForm();
            mExponentForm.MdiParent = this;
            mExponentForm.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FactorialForm mFactorialForm = new FactorialForm();
            mFactorialForm.MdiParent = this;
            mFactorialForm.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FibonacciForm mFibonacciForm = new FibonacciForm();
            mFibonacciForm.MdiParent = this;
            mFibonacciForm.Show();
        }

        private void torreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HanoiForm mTorreForm = new HanoiForm();
            mTorreForm.MdiParent = this;
            mTorreForm.Show();
        }

        private void sumaDeArreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SumArrayForm mSumArrayForm = new SumArrayForm();
            mSumArrayForm.MdiParent = this;
            mSumArrayForm.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas frmColas = new frmColas();
            frmColas.MdiParent = this;
            frmColas.Show();
        }

        private void lIstasSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas simples = new frmListas();
            simples.MdiParent = this;
            simples.Show();
        }

        private void listasDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasDobles frmListasDobles = new frmListasDobles();
            frmListasDobles.MdiParent = this;
            frmListasDobles.Show();
        }

        private void listasCircularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListasCirculares frmListasCirculares = new frmListasCirculares();
            frmListasCirculares.MdiParent = this;
            frmListasCirculares.Show();
        }

        private void listasCIrcularesDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircularesDobles frmCircularesDobles = new frmCircularesDobles();
            frmCircularesDobles.MdiParent = this;
            frmCircularesDobles.Show();
        }
    }
}
