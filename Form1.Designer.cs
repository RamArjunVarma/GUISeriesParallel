namespace GUISeriesParallel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLp = new System.Windows.Forms.Button();
            this.btnCp = new System.Windows.Forms.Button();
            this.btnLs = new System.Windows.Forms.Button();
            this.btnCs = new System.Windows.Forms.Button();
            this.btnRp = new System.Windows.Forms.Button();
            this.btnRs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnH
            // 
            this.btnH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(43, 25);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(922, 56);
            this.btnH.TabIndex = 0;
            this.btnH.Text = "Series / Parallel";
            this.btnH.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnLp);
            this.panel2.Controls.Add(this.btnCp);
            this.panel2.Controls.Add(this.btnLs);
            this.panel2.Controls.Add(this.btnCs);
            this.panel2.Controls.Add(this.btnRp);
            this.panel2.Controls.Add(this.btnRs);
            this.panel2.Location = new System.Drawing.Point(43, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 407);
            this.panel2.TabIndex = 1;
            // 
            // btnLp
            // 
            this.btnLp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLp.Location = new System.Drawing.Point(576, 289);
            this.btnLp.Name = "btnLp";
            this.btnLp.Size = new System.Drawing.Size(302, 57);
            this.btnLp.TabIndex = 5;
            this.btnLp.Text = "Inductors in Parallel";
            this.btnLp.UseVisualStyleBackColor = true;
            this.btnLp.Click += new System.EventHandler(this.btnLp_Click);
            // 
            // btnCp
            // 
            this.btnCp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCp.Location = new System.Drawing.Point(576, 166);
            this.btnCp.Name = "btnCp";
            this.btnCp.Size = new System.Drawing.Size(302, 57);
            this.btnCp.TabIndex = 4;
            this.btnCp.Text = "Capacitors in Parallel";
            this.btnCp.UseVisualStyleBackColor = true;
            this.btnCp.Click += new System.EventHandler(this.btnCp_Click);
            // 
            // btnLs
            // 
            this.btnLs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLs.Location = new System.Drawing.Point(87, 289);
            this.btnLs.Name = "btnLs";
            this.btnLs.Size = new System.Drawing.Size(302, 57);
            this.btnLs.TabIndex = 3;
            this.btnLs.Text = "Inductors in Series ";
            this.btnLs.UseVisualStyleBackColor = true;
            this.btnLs.Click += new System.EventHandler(this.btnLs_Click);
            // 
            // btnCs
            // 
            this.btnCs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCs.Location = new System.Drawing.Point(87, 166);
            this.btnCs.Name = "btnCs";
            this.btnCs.Size = new System.Drawing.Size(302, 57);
            this.btnCs.TabIndex = 2;
            this.btnCs.Text = "Capacitors in Series";
            this.btnCs.UseVisualStyleBackColor = true;
            this.btnCs.Click += new System.EventHandler(this.btnCs_Click);
            // 
            // btnRp
            // 
            this.btnRp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRp.Location = new System.Drawing.Point(576, 43);
            this.btnRp.Name = "btnRp";
            this.btnRp.Size = new System.Drawing.Size(302, 57);
            this.btnRp.TabIndex = 1;
            this.btnRp.Text = "Resistors in Parallel";
            this.btnRp.UseVisualStyleBackColor = true;
            this.btnRp.Click += new System.EventHandler(this.btnRp_Click);
            // 
            // btnRs
            // 
            this.btnRs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRs.Location = new System.Drawing.Point(87, 43);
            this.btnRs.Name = "btnRs";
            this.btnRs.Size = new System.Drawing.Size(302, 57);
            this.btnRs.TabIndex = 0;
            this.btnRs.Text = "Resistors in Series";
            this.btnRs.UseVisualStyleBackColor = true;
            this.btnRs.Click += new System.EventHandler(this.btnRs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SeriesParallel";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnRs;
        private System.Windows.Forms.Button btnLp;
        private System.Windows.Forms.Button btnCp;
        private System.Windows.Forms.Button btnLs;
        private System.Windows.Forms.Button btnCs;
        private System.Windows.Forms.Button btnRp;
    }
}

