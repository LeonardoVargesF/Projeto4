using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4
{
    public partial class FormRelatorioCurso : MaterialForm
    {
        string cs = @"server=127.0.0.1;" + "uid=root;" + "pwd=;" + "database=academico";
        private PdfDocument doc;
        public FormRelatorioCurso()
        {
            InitializeComponent();
            CarregaImpressoras();
        }
        private void CarregaImpressoras()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
            }
        }
        
        private void MontaRelatorio()
        {
            //consulta do banco de dados
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM curso WHERE 1 = 1";
            if (txtNomeCurso.Text != "")
                sql += " and nome = @nome";
            if (cboTipoCurso.Text != "")
                sql += " and tipo = @tipo";

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            if (cboTipoCurso.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@tipo", cboTipoCurso.Text);
            if (txtNomeCurso.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@nome", txtNomeCurso.Text);

            doc = new PdfDocument();

            var dt = new DataTable();
            sqlAd.Fill(dt);
            //inicio geração do pdf
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            int y = 20;
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatório de Cursos", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);



            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            //table.Style.HeaderRowCount = 1;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.ForestGreen;
            table.DataSource = dt;

            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }

            table.Draw(page, new Point(0, y + 30));

            doc.SaveToFile("RelatorioCursos.pdf");

            con.Close();

        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            MontaRelatorio();

            doc.LoadFromFile("RelatorioCursos.pdf");
            doc.PrintSettings.PrinterName = cboImpressora.Text;
            doc.Print();
        }

        private void btnVisualizar_Click_1(object sender, EventArgs e)
        {
            MontaRelatorio();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioCursos.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
