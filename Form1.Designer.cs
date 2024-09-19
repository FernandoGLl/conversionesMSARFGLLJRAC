namespace conversionesMSARFGLLJRAC
{
    partial class Form1
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
            TBX_DEC = new TextBox();
            TXB_CM = new TextBox();
            LBL_DEC = new Label();
            LBL_CM = new Label();
            BTTN_CONV = new Button();
            SuspendLayout();
            // 
            // TBX_DEC
            // 
            TBX_DEC.Location = new Point(75, 41);
            TBX_DEC.Name = "TBX_DEC";
            TBX_DEC.Size = new Size(290, 23);
            TBX_DEC.TabIndex = 0;
            TBX_DEC.TextChanged += TBX_HEXA_TextChanged;
            // 
            // TXB_CM
            // 
            TXB_CM.Location = new Point(75, 96);
            TXB_CM.Name = "TXB_CM";
            TXB_CM.Size = new Size(290, 23);
            TXB_CM.TabIndex = 1;
            TXB_CM.TextChanged += TXB_BIN_TextChanged;
            // 
            // LBL_DEC
            // 
            LBL_DEC.AutoSize = true;
            LBL_DEC.BackColor = Color.LightCoral;
            LBL_DEC.Location = new Point(411, 46);
            LBL_DEC.Name = "LBL_DEC";
            LBL_DEC.Size = new Size(57, 15);
            LBL_DEC.TabIndex = 3;
            LBL_DEC.Text = "DECIMAL";
            // 
            // LBL_CM
            // 
            LBL_CM.AutoSize = true;
            LBL_CM.BackColor = Color.SkyBlue;
            LBL_CM.ForeColor = SystemColors.ControlText;
            LBL_CM.Location = new Point(411, 99);
            LBL_CM.Name = "LBL_CM";
            LBL_CM.Size = new Size(111, 15);
            LBL_CM.TabIndex = 4;
            LBL_CM.Text = "CODIGO MAQUINA";
            // 
            // BTTN_CONV
            // 
            BTTN_CONV.Location = new Point(161, 137);
            BTTN_CONV.Name = "BTTN_CONV";
            BTTN_CONV.Size = new Size(105, 23);
            BTTN_CONV.TabIndex = 5;
            BTTN_CONV.Text = "CONVERTIR";
            BTTN_CONV.UseVisualStyleBackColor = true;
            BTTN_CONV.Click += BTTN_CONV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(557, 196);
            Controls.Add(BTTN_CONV);
            Controls.Add(LBL_CM);
            Controls.Add(LBL_DEC);
            Controls.Add(TXB_CM);
            Controls.Add(TBX_DEC);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBX_DEC;
        private TextBox TXB_CM;
        private Label LBL_DEC;
        private Label LBL_CM;
        private Button BTTN_CONV;
    }
}
