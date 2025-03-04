namespace AutoSystem_KingMe
{
    partial class Lobby
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetMatches = new Button();
            panel1 = new Panel();
            lboMatches = new ListBox();
            label3 = new Label();
            label2 = new Label();
            cboMatchesStatus = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetMatches
            // 
            btnGetMatches.AllowDrop = true;
            btnGetMatches.Location = new Point(232, 30);
            btnGetMatches.Name = "btnGetMatches";
            btnGetMatches.Size = new Size(157, 44);
            btnGetMatches.TabIndex = 0;
            btnGetMatches.Text = "Consultar partidas";
            btnGetMatches.UseVisualStyleBackColor = true;
            btnGetMatches.Click += btnGetMatches_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lboMatches);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboMatchesStatus);
            panel1.Controls.Add(btnGetMatches);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 451);
            panel1.TabIndex = 3;
            // 
            // lboMatches
            // 
            lboMatches.FormattingEnabled = true;
            lboMatches.Location = new Point(24, 106);
            lboMatches.Name = "lboMatches";
            lboMatches.Size = new Size(365, 324);
            lboMatches.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(21, 83);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 13;
            label3.Text = "Partidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(23, 21);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Status";
            // 
            // cboMatchesStatus
            // 
            cboMatchesStatus.CausesValidation = false;
            cboMatchesStatus.FormattingEnabled = true;
            cboMatchesStatus.Items.AddRange(new object[] { "T - Todas", "A - Abertas", "J - Em Jogo", "E - Encerradas" });
            cboMatchesStatus.Location = new Point(24, 44);
            cboMatchesStatus.Name = "cboMatchesStatus";
            cboMatchesStatus.Size = new Size(193, 28);
            cboMatchesStatus.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 11;
            label1.Text = "Consultar Partidas";
            // 
            // Lobby
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 505);
            Controls.Add(label1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "Lobby";
            Text = "Lobby";
            Load += Lobby_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetMatches;
        private Panel panel1;
        private ComboBox cboMatchesStatus;
        private Label label1;
        private Label label2;
        private ListBox lboMatches;
        private Label label3;
    }
}
