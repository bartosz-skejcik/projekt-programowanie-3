using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr3_Paczesny_72541
{
    public partial class Form1 : Form
    {
        private const int margin = 10;

        // Wartości nominałów dla poszczególnych walut
        private ushort[] denominationValuesPLN = { 200, 100, 50, 20, 10 };
        private ushort[] denominationValuesEUR = { 500, 200, 50, 20, 10, 5 };
        private ushort[] denominationValuesUSD = { 100, 50, 20, 10, 5, 1 };
        
        private ushort[] denominationValues;
        
        // Deklaracja elementu tablicy reprezentującej pojemnik nominałów
        struct Denomination
        {
            public ushort value;
            public ushort quantity;
        }
        
        // Deklaracja pojemnika nominałów Bankomatu
        private Denomination bankDenominations;
        public Form1()
        {
            InitializeComponent();
            // Lokalizacja i wymiarowanie formularza
            Location = new Point(Screen.PrimaryScreen.Bounds.X + margin, Screen.PrimaryScreen.Bounds.Y + margin);
            // Mozna dac 100%
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
            StartPosition = FormStartPosition.Manual;
            // uniemozliwienie zmany rozmiaru formularza poprzez przeciaganie krawedzi
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            // ukrycie przyciskow minimalizacji i maksymalizacji
            MinimizeBox = false;
            MaximizeBox = false;
            
            // formatowanie zakladki aby wypelniala caly ekran
            bpTabControl.Dock = DockStyle.Fill;
            bpTabControl.SelectedTab = bpTabPageBank;
        }

        private void bpTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // podczas wywolania tej funkcji, jako parametr jest podawany `e`, on ma rozne wlasciosci dotyczace zakladki w ktorą kliknelismy
            // jedną z własciwosci jest `TabPage`, ktora jest zakladka na ktora kliknelismy
            // z kazdej strony mozna wrocic na pierwsza strone
            if (e.TabPage == bpTabControl.TabPages[0])
            {
                e.Cancel = false;
                // odsloniecie strony powitalnej
                bpTabControl.SelectedTab = bpTabPageWelcome;
            }
            else if (e.TabPage == bpTabControl.TabPages[1])
            {
                e.Cancel = false;
                // odsloniecie strony powitalnej
                bpTabControl.SelectedTab = bpTabPageBank;
            }
            else if (e.TabPage == bpTabControl.TabPages[2])
            {
                e.Cancel = false;
                // odsloniecie strony powitalnej
                bpTabControl.SelectedTab = bpTabPageVending;
            }
        }

        private void bpComboBoxDenomination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bpComboBoxDenomination.SelectedIndex == 0)
            {
                denominationValues = denominationValuesPLN;
            } else if (bpComboBoxDenomination.SelectedIndex == 1)
            {
                denominationValues = denominationValuesEUR;
            } else if (bpComboBoxDenomination.SelectedIndex == 2)
            {
                denominationValues = denominationValuesUSD;
            } else
            {
                MessageBox.Show("Nie wybrano waluty");
            }
        }
    }
}