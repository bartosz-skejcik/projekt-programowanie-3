using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjektNr3_Paczesny_72541
{
    public partial class Form1 : Form
    {
        // consts usually should be in uppercase
        private const ushort BPMARGIN = 10;
        private const ushort BPMIN = 1;
        private const ushort BPMAX = 100;


        // Wartości nominałów dla poszczególnych walut
        private ushort[] bpDenominationValuesPLN = { 200, 100, 50, 20, 10 };
        private ushort[] bpDenominationValuesEUR = { 500, 200, 50, 20, 10, 5 };
        private ushort[] bpDenominationValuesUSD = { 100, 50, 20, 10, 5, 1 };
      
        private ushort[] bpDenominationValues;
        
        // Deklaracja elementu tablicy reprezentującej pojemnik nominałów
        public struct bpDenomination
        {
            public ushort bpValue;
            public ushort bpQuantity;
        }
        
        // Deklaracja pojemnika nominałów Bankomatu
        private bpDenomination[] bpBankDenominations;
        public Form1()
        {
            InitializeComponent();
            // Lokalizacja i wymiarowanie formularza
            Location = new Point(Screen.PrimaryScreen.Bounds.X + BPMARGIN, Screen.PrimaryScreen.Bounds.Y + BPMARGIN);
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
            // zgaszenie error providera
            bpErrorProvider.Dispose();
            
            switch (bpComboBoxDenomination.SelectedIndex)
            {
                case 0:
                    bpDenominationValues = bpDenominationValuesPLN;
                    break;
                case 1:
                    bpDenominationValues = bpDenominationValuesEUR;
                    break;
                case 2:
                    bpDenominationValues = bpDenominationValuesUSD;
                    break;
                default:
                    bpErrorProvider.SetError(bpComboBoxDenomination, "Podano błędną walutę!");
                    break;
            }

            bpBankDenominations = new bpDenomination[bpDenominationValues.Length];
            bpRadioBtnRandom.Enabled = true;
            bpRadioBtnAlloc.Enabled = true;
            bpBtnAcceptDenominationCount.Enabled = true;
        }

        private void bpBtnAcceptDenominationCount_Click(object sender, EventArgs e)
        {
            bpErrorProvider.Dispose();
            
            // check if a radio is checked
            if (!bpRadioBtnRandom.Checked && !bpRadioBtnAlloc.Checked)
            {
                bpErrorProvider.SetError(bpBtnAcceptDenominationCount, "Nie wybrano sposobu alokacji nominałów!");
                return;
            }
            
            // EXTRA: check if a denomination is selected
            if (bpComboBoxDenomination.SelectedIndex == -1)
            {
                bpErrorProvider.SetError(bpComboBoxDenomination, "Nie wybrano waluty!");
                return;
            }

            bpTxtWithdrawValue.Enabled = true;
            bpBtnWithdrawAccept.Enabled = true;

            if (bpRadioBtnRandom.Checked)
            {
                // get a random count of denominations
                Random bpRandom = new Random();
                
                for (ushort bpI = 0; bpI < bpDenominationValues.Length; bpI++)
                {
                    bpBankDenominations[bpI].bpValue = bpDenominationValues[bpI];
                    bpBankDenominations[bpI].bpQuantity = (ushort) bpRandom.Next(BPMIN, BPMAX);
                }
                
                bpDgvAvailableDenominations.Rows.Clear();
                
                // enter these values into the bpDgvAvailableDenominations
                for (ushort bpI = 0; bpI < bpDenominationValues.Length; bpI++)
                {
                    bpDgvAvailableDenominations.Rows.Add(bpBankDenominations[bpI].bpQuantity, bpBankDenominations[bpI].bpValue);
                    
                    for (ushort bpK = 0; bpK < bpDgvAvailableDenominations.Columns.Count; bpK++)
                    {
                        bpDgvAvailableDenominations.Rows[bpI].Cells[bpK].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }

                bpBtnAcceptDenominationCount.Enabled = false;
            }
            else
            {
                // TODO: Implement the allocation of denominations
                MessageBox.Show("Funkcjonalność w trakcie realizacji");
            }
        }

        private void bpBtnWithdrawAccept_Click(object sender, EventArgs e)
        {
            bpErrorProvider.Dispose();
            
            ushort bpWithdrawValue;
            
            if (ushort.TryParse(bpTxtWithdrawValue.Text, out bpWithdrawValue))
            {
                bpErrorProvider.SetError(bpTxtWithdrawValue, "Błędny format kwoty do wypłaty!");
                return;
            }
            
            ushort bpLowestDenominationValue = bpDenominationValues[bpDenominationValues.Length - 1];
            
            // We divide the check into 2 so that the error message is more descriptive of the error itself
            // EXTRA: check if the value is less than 0 or less than the lowest denomination
            if (bpWithdrawValue <= 0 || bpWithdrawValue < bpLowestDenominationValue)
            {
                bpErrorProvider.SetError(bpTxtWithdrawValue, "Kwota do wypłaty jest mniejsza niż najmniejszy nominał!");
                return;
            }
            
            // check if the value is divisible by the smallest denomination
            if (bpWithdrawValue % bpLowestDenominationValue != 0)
            {
                bpErrorProvider.SetError(bpTxtWithdrawValue, "Kwota do wypłaty nie jest podzielna przez najmniejszy nominał!");
                return;
            }
            
            bpDenomination[] bpWithdrawCombination = BpHelper.bpGetWithdrawCombination(bpWithdrawValue, bpBankDenominations);
            

            if (bpWithdrawCombination.Length == 0)
            {
                bpErrorProvider.SetError(bpBtnWithdrawAccept, "Nie jesteśmy w stanie zrealizować tej wypłaty.\nPodaj mniejszą kwotę.");
            }
            
            // console log the result
            Console.WriteLine(bpWithdrawCombination);
        }
    }
}