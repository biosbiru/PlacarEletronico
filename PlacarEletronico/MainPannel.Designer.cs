namespace PlacarEletronico
{
    partial class FormPannel
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
            pnlDisplay = new Panel();
            lblVersus = new Label();
            panel5 = new Panel();
            lblTeam2Points = new Label();
            panel4 = new Panel();
            lblTeam1Points = new Label();
            pnlDisplayTeam2 = new Panel();
            lblTeam2 = new Label();
            pnlDisplayTeam1 = new Panel();
            lblTeam1 = new Label();
            pnlAdmin = new Panel();
            btnTeam2Remove = new Button();
            btnTeam2Add = new Button();
            txtTeam2 = new TextBox();
            btnTeam1Remove = new Button();
            btnTeam1Add = new Button();
            grpAdminChrono = new GroupBox();
            btnReset = new Button();
            btnPause = new Button();
            radFirstStep = new RadioButton();
            btnStart = new Button();
            radSecondStep = new RadioButton();
            txtTeam1 = new TextBox();
            lblAdminTeam2 = new Label();
            lblAdminTeam1 = new Label();
            pnlDisplayChrono = new Panel();
            lblStep = new Label();
            panel10 = new Panel();
            lblTimer = new Label();
            pnlDisplay.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            pnlDisplayTeam2.SuspendLayout();
            pnlDisplayTeam1.SuspendLayout();
            pnlAdmin.SuspendLayout();
            grpAdminChrono.SuspendLayout();
            pnlDisplayChrono.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = SystemColors.ActiveBorder;
            pnlDisplay.Controls.Add(lblVersus);
            pnlDisplay.Controls.Add(panel5);
            pnlDisplay.Controls.Add(panel4);
            pnlDisplay.Controls.Add(pnlDisplayTeam2);
            pnlDisplay.Controls.Add(pnlDisplayTeam1);
            pnlDisplay.ForeColor = SystemColors.ActiveBorder;
            pnlDisplay.Location = new Point(12, 30);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(362, 51);
            pnlDisplay.TabIndex = 0;
            // 
            // lblVersus
            // 
            lblVersus.AutoSize = true;
            lblVersus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersus.ForeColor = SystemColors.WindowFrame;
            lblVersus.Location = new Point(169, 10);
            lblVersus.Name = "lblVersus";
            lblVersus.Size = new Size(27, 30);
            lblVersus.TabIndex = 3;
            lblVersus.Text = "X";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GrayText;
            panel5.Controls.Add(lblTeam2Points);
            panel5.Location = new Point(196, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(36, 38);
            panel5.TabIndex = 2;
            // 
            // lblTeam2Points
            // 
            lblTeam2Points.AutoSize = true;
            lblTeam2Points.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeam2Points.ForeColor = SystemColors.InactiveBorder;
            lblTeam2Points.Location = new Point(2, -2);
            lblTeam2Points.Name = "lblTeam2Points";
            lblTeam2Points.Size = new Size(34, 40);
            lblTeam2Points.TabIndex = 4;
            lblTeam2Points.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GrayText;
            panel4.Controls.Add(lblTeam1Points);
            panel4.Location = new Point(130, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(36, 38);
            panel4.TabIndex = 1;
            // 
            // lblTeam1Points
            // 
            lblTeam1Points.AutoSize = true;
            lblTeam1Points.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeam1Points.ForeColor = SystemColors.InactiveBorder;
            lblTeam1Points.Location = new Point(3, -2);
            lblTeam1Points.Name = "lblTeam1Points";
            lblTeam1Points.Size = new Size(34, 40);
            lblTeam1Points.TabIndex = 3;
            lblTeam1Points.Text = "0";
            // 
            // pnlDisplayTeam2
            // 
            pnlDisplayTeam2.BackColor = SystemColors.Control;
            pnlDisplayTeam2.Controls.Add(lblTeam2);
            pnlDisplayTeam2.Location = new Point(238, 6);
            pnlDisplayTeam2.Name = "pnlDisplayTeam2";
            pnlDisplayTeam2.Size = new Size(117, 38);
            pnlDisplayTeam2.TabIndex = 1;
            // 
            // lblTeam2
            // 
            lblTeam2.AutoSize = true;
            lblTeam2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeam2.ForeColor = SystemColors.WindowFrame;
            lblTeam2.Location = new Point(34, 4);
            lblTeam2.Name = "lblTeam2";
            lblTeam2.Size = new Size(50, 30);
            lblTeam2.TabIndex = 3;
            lblTeam2.Text = "FLA";
            // 
            // pnlDisplayTeam1
            // 
            pnlDisplayTeam1.BackColor = SystemColors.Control;
            pnlDisplayTeam1.Controls.Add(lblTeam1);
            pnlDisplayTeam1.Location = new Point(7, 6);
            pnlDisplayTeam1.Name = "pnlDisplayTeam1";
            pnlDisplayTeam1.Size = new Size(117, 38);
            pnlDisplayTeam1.TabIndex = 0;
            // 
            // lblTeam1
            // 
            lblTeam1.AutoSize = true;
            lblTeam1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeam1.ForeColor = SystemColors.WindowFrame;
            lblTeam1.Location = new Point(29, 4);
            lblTeam1.Name = "lblTeam1";
            lblTeam1.Size = new Size(53, 30);
            lblTeam1.TabIndex = 2;
            lblTeam1.Text = "VAS";
            // 
            // pnlAdmin
            // 
            pnlAdmin.BackColor = SystemColors.Info;
            pnlAdmin.Controls.Add(btnTeam2Remove);
            pnlAdmin.Controls.Add(btnTeam2Add);
            pnlAdmin.Controls.Add(txtTeam2);
            pnlAdmin.Controls.Add(btnTeam1Remove);
            pnlAdmin.Controls.Add(btnTeam1Add);
            pnlAdmin.Controls.Add(grpAdminChrono);
            pnlAdmin.Controls.Add(txtTeam1);
            pnlAdmin.Controls.Add(lblAdminTeam2);
            pnlAdmin.Controls.Add(lblAdminTeam1);
            pnlAdmin.Location = new Point(40, 123);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(449, 209);
            pnlAdmin.TabIndex = 1;
            // 
            // btnTeam2Remove
            // 
            btnTeam2Remove.Location = new Point(244, 52);
            btnTeam2Remove.Name = "btnTeam2Remove";
            btnTeam2Remove.Size = new Size(25, 23);
            btnTeam2Remove.TabIndex = 16;
            btnTeam2Remove.Text = "-";
            btnTeam2Remove.UseVisualStyleBackColor = true;
            // 
            // btnTeam2Add
            // 
            btnTeam2Add.Location = new Point(213, 52);
            btnTeam2Add.Name = "btnTeam2Add";
            btnTeam2Add.Size = new Size(25, 23);
            btnTeam2Add.TabIndex = 15;
            btnTeam2Add.Text = "+";
            btnTeam2Add.UseVisualStyleBackColor = true;
            // 
            // txtTeam2
            // 
            txtTeam2.Location = new Point(102, 52);
            txtTeam2.Name = "txtTeam2";
            txtTeam2.Size = new Size(100, 23);
            txtTeam2.TabIndex = 14;
            // 
            // btnTeam1Remove
            // 
            btnTeam1Remove.Location = new Point(244, 22);
            btnTeam1Remove.Name = "btnTeam1Remove";
            btnTeam1Remove.Size = new Size(25, 23);
            btnTeam1Remove.TabIndex = 13;
            btnTeam1Remove.Text = "-";
            btnTeam1Remove.UseVisualStyleBackColor = true;
            // 
            // btnTeam1Add
            // 
            btnTeam1Add.Location = new Point(213, 22);
            btnTeam1Add.Name = "btnTeam1Add";
            btnTeam1Add.Size = new Size(25, 23);
            btnTeam1Add.TabIndex = 12;
            btnTeam1Add.Text = "+";
            btnTeam1Add.UseVisualStyleBackColor = true;
            // 
            // grpAdminChrono
            // 
            grpAdminChrono.Controls.Add(btnReset);
            grpAdminChrono.Controls.Add(btnPause);
            grpAdminChrono.Controls.Add(radFirstStep);
            grpAdminChrono.Controls.Add(btnStart);
            grpAdminChrono.Controls.Add(radSecondStep);
            grpAdminChrono.Location = new Point(10, 97);
            grpAdminChrono.Name = "grpAdminChrono";
            grpAdminChrono.Size = new Size(422, 95);
            grpAdminChrono.TabIndex = 10;
            grpAdminChrono.TabStop = false;
            grpAdminChrono.Text = "Cronometro";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(193, 29);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 44);
            btnReset.TabIndex = 11;
            btnReset.Text = "Resetar";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(105, 29);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(82, 44);
            btnPause.TabIndex = 10;
            btnPause.Text = "Pausar";
            btnPause.UseVisualStyleBackColor = true;
            // 
            // radFirstStep
            // 
            radFirstStep.AutoSize = true;
            radFirstStep.Location = new Point(296, 29);
            radFirstStep.Name = "radFirstStep";
            radFirstStep.Size = new Size(109, 19);
            radFirstStep.TabIndex = 7;
            radFirstStep.TabStop = true;
            radFirstStep.Text = "Primeiro Tempo";
            radFirstStep.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(17, 29);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(82, 44);
            btnStart.TabIndex = 9;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // radSecondStep
            // 
            radSecondStep.AutoSize = true;
            radSecondStep.Location = new Point(296, 54);
            radSecondStep.Name = "radSecondStep";
            radSecondStep.Size = new Size(111, 19);
            radSecondStep.TabIndex = 8;
            radSecondStep.TabStop = true;
            radSecondStep.Text = "Segundo Tempo";
            radSecondStep.UseVisualStyleBackColor = true;
            // 
            // txtTeam1
            // 
            txtTeam1.Location = new Point(102, 22);
            txtTeam1.Name = "txtTeam1";
            txtTeam1.Size = new Size(100, 23);
            txtTeam1.TabIndex = 5;
            // 
            // lblAdminTeam2
            // 
            lblAdminTeam2.AutoSize = true;
            lblAdminTeam2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminTeam2.ForeColor = SystemColors.WindowFrame;
            lblAdminTeam2.Location = new Point(15, 47);
            lblAdminTeam2.Name = "lblAdminTeam2";
            lblAdminTeam2.Size = new Size(81, 30);
            lblAdminTeam2.TabIndex = 4;
            lblAdminTeam2.Text = "TIME 2";
            // 
            // lblAdminTeam1
            // 
            lblAdminTeam1.AutoSize = true;
            lblAdminTeam1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminTeam1.ForeColor = SystemColors.WindowFrame;
            lblAdminTeam1.Location = new Point(15, 17);
            lblAdminTeam1.Name = "lblAdminTeam1";
            lblAdminTeam1.Size = new Size(81, 30);
            lblAdminTeam1.TabIndex = 3;
            lblAdminTeam1.Text = "TIME 1";
            // 
            // pnlDisplayChrono
            // 
            pnlDisplayChrono.BackColor = SystemColors.ControlDarkDark;
            pnlDisplayChrono.Controls.Add(lblStep);
            pnlDisplayChrono.Controls.Add(panel10);
            pnlDisplayChrono.ForeColor = SystemColors.ControlDarkDark;
            pnlDisplayChrono.Location = new Point(379, 30);
            pnlDisplayChrono.Name = "pnlDisplayChrono";
            pnlDisplayChrono.Size = new Size(135, 51);
            pnlDisplayChrono.TabIndex = 4;
            // 
            // lblStep
            // 
            lblStep.AutoSize = true;
            lblStep.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep.ForeColor = SystemColors.InactiveBorder;
            lblStep.Location = new Point(83, 5);
            lblStep.Name = "lblStep";
            lblStep.Size = new Size(51, 40);
            lblStep.TabIndex = 5;
            lblStep.Text = "1T";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.Control;
            panel10.Location = new Point(9, 10);
            panel10.Name = "panel10";
            panel10.Size = new Size(74, 33);
            panel10.TabIndex = 1;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = SystemColors.WindowFrame;
            lblTimer.Location = new Point(392, 41);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(67, 30);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "45:00";
            // 
            // FormPannel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 368);
            Controls.Add(lblTimer);
            Controls.Add(pnlDisplayChrono);
            Controls.Add(pnlAdmin);
            Controls.Add(pnlDisplay);
            Name = "FormPannel";
            Text = "Sport Display Pannel";
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlDisplayTeam2.ResumeLayout(false);
            pnlDisplayTeam2.PerformLayout();
            pnlDisplayTeam1.ResumeLayout(false);
            pnlDisplayTeam1.PerformLayout();
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            grpAdminChrono.ResumeLayout(false);
            grpAdminChrono.PerformLayout();
            pnlDisplayChrono.ResumeLayout(false);
            pnlDisplayChrono.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDisplay;
        private Panel panel5;
        private Panel panel4;
        private Panel pnlDisplayTeam2;
        private Panel pnlDisplayTeam1;
        private Panel pnlAdmin;
        private Label lblTeam2;
        private Label lblTeam1;
        private Label lblVersus;
        private Label lblTeam2Points;
        private Label lblTeam1Points;
        private Panel pnlDisplayChrono;
        private Panel panel10;
        private Label lblStep;
        private Label lblTimer;
        private GroupBox grpAdminChrono;
        private Button btnReset;
        private Button btnPause;
        private RadioButton radFirstStep;
        private Button btnStart;
        private RadioButton radSecondStep;
        private TextBox txtTeam1;
        private Label lblAdminTeam2;
        private Label lblAdminTeam1;
        private Button btnTeam2Remove;
        private Button btnTeam2Add;
        private TextBox txtTeam2;
        private Button btnTeam1Remove;
        private Button btnTeam1Add;
    }
}
