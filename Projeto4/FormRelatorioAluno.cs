using ReaLTaiizor.Forms;
using System.Drawing.Configuration;

namespace Projeto4
{
    public partial class FormRelatorioAluno : MaterialForm
    {
        public FormRelatorioAluno()
        {
            InitializeComponent();
            CarregaImpressoras();
        }

        private void CarregaImpressoras()
        {
            foreach(string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
            }
        }

    }
}
