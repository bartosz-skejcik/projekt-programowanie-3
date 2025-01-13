namespace ProjektNr3_Paczesny_72541
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bpTabControl = new System.Windows.Forms.TabControl();
            this.bpTabPageWelcome = new System.Windows.Forms.TabPage();
            this.bpTabPageBank = new System.Windows.Forms.TabPage();
            this.bpBtnNext = new System.Windows.Forms.Button();
            this.bpBtnWithdrawAccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bpGroupBoxDenomination = new System.Windows.Forms.GroupBox();
            this.bpBtnAcceptDenominationCount = new System.Windows.Forms.Button();
            this.bpRadioBtnAlloc = new System.Windows.Forms.RadioButton();
            this.bpRadioBtnRandom = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no_of_denominations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denomination_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bpComboBoxDenomination = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bpTabPageVending = new System.Windows.Forms.TabPage();
            this.bpTabControl.SuspendLayout();
            this.bpTabPageBank.SuspendLayout();
            this.bpGroupBoxDenomination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bpTabControl
            // 
            this.bpTabControl.Controls.Add(this.bpTabPageWelcome);
            this.bpTabControl.Controls.Add(this.bpTabPageBank);
            this.bpTabControl.Controls.Add(this.bpTabPageVending);
            this.bpTabControl.Location = new System.Drawing.Point(12, 12);
            this.bpTabControl.Name = "bpTabControl";
            this.bpTabControl.SelectedIndex = 0;
            this.bpTabControl.Size = new System.Drawing.Size(928, 426);
            this.bpTabControl.TabIndex = 0;
            this.bpTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.bpTabControl_Selecting);
            // 
            // bpTabPageWelcome
            // 
            this.bpTabPageWelcome.BackColor = System.Drawing.Color.DimGray;
            this.bpTabPageWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bpTabPageWelcome.Location = new System.Drawing.Point(4, 22);
            this.bpTabPageWelcome.Name = "bpTabPageWelcome";
            this.bpTabPageWelcome.Size = new System.Drawing.Size(920, 400);
            this.bpTabPageWelcome.TabIndex = 2;
            this.bpTabPageWelcome.Text = "Strona powitalna";
            // 
            // bpTabPageBank
            // 
            this.bpTabPageBank.BackColor = System.Drawing.Color.DimGray;
            this.bpTabPageBank.Controls.Add(this.bpBtnNext);
            this.bpTabPageBank.Controls.Add(this.bpBtnWithdrawAccept);
            this.bpTabPageBank.Controls.Add(this.label3);
            this.bpTabPageBank.Controls.Add(this.textBox3);
            this.bpTabPageBank.Controls.Add(this.label2);
            this.bpTabPageBank.Controls.Add(this.bpGroupBoxDenomination);
            this.bpTabPageBank.Controls.Add(this.dataGridView1);
            this.bpTabPageBank.Controls.Add(this.label1);
            this.bpTabPageBank.Controls.Add(this.bpComboBoxDenomination);
            this.bpTabPageBank.Controls.Add(this.textBox1);
            this.bpTabPageBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bpTabPageBank.Location = new System.Drawing.Point(4, 22);
            this.bpTabPageBank.Name = "bpTabPageBank";
            this.bpTabPageBank.Padding = new System.Windows.Forms.Padding(3);
            this.bpTabPageBank.Size = new System.Drawing.Size(920, 400);
            this.bpTabPageBank.TabIndex = 0;
            this.bpTabPageBank.Text = "Bankomat";
            // 
            // bpBtnNext
            // 
            this.bpBtnNext.ForeColor = System.Drawing.Color.Black;
            this.bpBtnNext.Location = new System.Drawing.Point(684, 181);
            this.bpBtnNext.Name = "bpBtnNext";
            this.bpBtnNext.Size = new System.Drawing.Size(176, 23);
            this.bpBtnNext.TabIndex = 11;
            this.bpBtnNext.Text = "Następny klient";
            this.bpBtnNext.UseVisualStyleBackColor = true;
            // 
            // bpBtnWithdrawAccept
            // 
            this.bpBtnWithdrawAccept.ForeColor = System.Drawing.Color.Black;
            this.bpBtnWithdrawAccept.Location = new System.Drawing.Point(683, 152);
            this.bpBtnWithdrawAccept.Name = "bpBtnWithdrawAccept";
            this.bpBtnWithdrawAccept.Size = new System.Drawing.Size(177, 23);
            this.bpBtnWithdrawAccept.TabIndex = 10;
            this.bpBtnWithdrawAccept.Text = "Wypłać";
            this.bpBtnWithdrawAccept.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pojemnkik walutowy Bankomatu";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(683, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Podaj wysokość wymaganej kwoty do wypłaty";
            // 
            // bpGroupBoxDenomination
            // 
            this.bpGroupBoxDenomination.Controls.Add(this.bpBtnAcceptDenominationCount);
            this.bpGroupBoxDenomination.Controls.Add(this.bpRadioBtnAlloc);
            this.bpGroupBoxDenomination.Controls.Add(this.bpRadioBtnRandom);
            this.bpGroupBoxDenomination.Location = new System.Drawing.Point(285, 78);
            this.bpGroupBoxDenomination.Name = "bpGroupBoxDenomination";
            this.bpGroupBoxDenomination.Size = new System.Drawing.Size(330, 53);
            this.bpGroupBoxDenomination.TabIndex = 6;
            this.bpGroupBoxDenomination.TabStop = false;
            this.bpGroupBoxDenomination.Text = "Ustawienie liczności nominałów w Bankomacie";
            // 
            // bpBtnAcceptDenominationCount
            // 
            this.bpBtnAcceptDenominationCount.ForeColor = System.Drawing.Color.Black;
            this.bpBtnAcceptDenominationCount.Location = new System.Drawing.Point(226, 19);
            this.bpBtnAcceptDenominationCount.Name = "bpBtnAcceptDenominationCount";
            this.bpBtnAcceptDenominationCount.Size = new System.Drawing.Size(75, 23);
            this.bpBtnAcceptDenominationCount.TabIndex = 2;
            this.bpBtnAcceptDenominationCount.Text = "Akceptuj";
            this.bpBtnAcceptDenominationCount.UseVisualStyleBackColor = true;
            // 
            // bpRadioBtnAlloc
            // 
            this.bpRadioBtnAlloc.Location = new System.Drawing.Point(116, 19);
            this.bpRadioBtnAlloc.Name = "bpRadioBtnAlloc";
            this.bpRadioBtnAlloc.Size = new System.Drawing.Size(104, 24);
            this.bpRadioBtnAlloc.TabIndex = 1;
            this.bpRadioBtnAlloc.TabStop = true;
            this.bpRadioBtnAlloc.Text = "Przydzialowo";
            this.bpRadioBtnAlloc.UseVisualStyleBackColor = true;
            // 
            // bpRadioBtnRandom
            // 
            this.bpRadioBtnRandom.Location = new System.Drawing.Point(27, 19);
            this.bpRadioBtnRandom.Name = "bpRadioBtnRandom";
            this.bpRadioBtnRandom.Size = new System.Drawing.Size(83, 24);
            this.bpRadioBtnRandom.TabIndex = 0;
            this.bpRadioBtnRandom.TabStop = true;
            this.bpRadioBtnRandom.Text = "Losowo";
            this.bpRadioBtnRandom.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.no_of_denominations, this.denomination_value });
            this.dataGridView1.Location = new System.Drawing.Point(32, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(184, 156);
            this.dataGridView1.TabIndex = 4;
            // 
            // no_of_denominations
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.no_of_denominations.DefaultCellStyle = dataGridViewCellStyle1;
            this.no_of_denominations.HeaderText = "Liczba nominałów";
            this.no_of_denominations.Name = "no_of_denominations";
            this.no_of_denominations.Width = 70;
            // 
            // denomination_value
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.denomination_value.DefaultCellStyle = dataGridViewCellStyle2;
            this.denomination_value.HeaderText = "Wartość nominałów";
            this.denomination_value.Name = "denomination_value";
            this.denomination_value.Width = 70;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz walute";
            // 
            // bpComboBoxDenomination
            // 
            this.bpComboBoxDenomination.FormattingEnabled = true;
            this.bpComboBoxDenomination.Items.AddRange(new object[] { "PLN", "EUR", "USD" });
            this.bpComboBoxDenomination.Location = new System.Drawing.Point(32, 97);
            this.bpComboBoxDenomination.Name = "bpComboBoxDenomination";
            this.bpComboBoxDenomination.Size = new System.Drawing.Size(184, 21);
            this.bpComboBoxDenomination.TabIndex = 2;
            this.bpComboBoxDenomination.SelectedIndexChanged += new System.EventHandler(this.bpComboBoxDenomination_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "SYMULATOR BANKOMATU\r\n(umożliwia dokonywanie wypłat w różnych walutach)";
            // 
            // bpTabPageVending
            // 
            this.bpTabPageVending.BackColor = System.Drawing.Color.DimGray;
            this.bpTabPageVending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bpTabPageVending.Location = new System.Drawing.Point(4, 22);
            this.bpTabPageVending.Name = "bpTabPageVending";
            this.bpTabPageVending.Padding = new System.Windows.Forms.Padding(3);
            this.bpTabPageVending.Size = new System.Drawing.Size(920, 400);
            this.bpTabPageVending.TabIndex = 1;
            this.bpTabPageVending.Text = "Automat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.bpTabControl);
            this.Name = "Form1";
            this.Text = "Symulator Bankomatu i Automatu Vendingowego";
            this.bpTabControl.ResumeLayout(false);
            this.bpTabPageBank.ResumeLayout(false);
            this.bpTabPageBank.PerformLayout();
            this.bpGroupBoxDenomination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bpBtnNext;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bpBtnWithdrawAccept;

        private System.Windows.Forms.Button bpBtnAcceptDenominationCount;

        private System.Windows.Forms.RadioButton bpRadioBtnAlloc;

        private System.Windows.Forms.GroupBox bpGroupBoxDenomination;
        private System.Windows.Forms.RadioButton bpRadioBtnRandom;

        private System.Windows.Forms.DataGridViewTextBoxColumn denomination_value;

        private System.Windows.Forms.DataGridViewTextBoxColumn no_of_denominations;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.ComboBox bpComboBoxDenomination;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TabPage bpTabPageWelcome;

        private System.Windows.Forms.TabControl bpTabControl;
        private System.Windows.Forms.TabPage bpTabPageBank;
        private System.Windows.Forms.TabPage bpTabPageVending;

        #endregion
    }
}