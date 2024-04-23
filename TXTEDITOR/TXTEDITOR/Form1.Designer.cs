namespace TXTEDITOR
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnBold = new System.Windows.Forms.Button();
            this.BtnUkoseno = new System.Windows.Forms.Button();
            this.BtnPocrtano = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(764, 302);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(31, 67);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(82, 36);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(254, 68);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(78, 35);
            this.BtnNew.TabIndex = 3;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnBold
            // 
            this.BtnBold.Location = new System.Drawing.Point(422, 66);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(74, 35);
            this.BtnBold.TabIndex = 4;
            this.BtnBold.Text = "B";
            this.BtnBold.UseVisualStyleBackColor = true;
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // BtnUkoseno
            // 
            this.BtnUkoseno.Location = new System.Drawing.Point(525, 66);
            this.BtnUkoseno.Name = "BtnUkoseno";
            this.BtnUkoseno.Size = new System.Drawing.Size(77, 34);
            this.BtnUkoseno.TabIndex = 5;
            this.BtnUkoseno.Text = "Ukoseno";
            this.BtnUkoseno.UseVisualStyleBackColor = true;
            this.BtnUkoseno.Click += new System.EventHandler(this.BtnUkoseno_Click);
            // 
            // BtnPocrtano
            // 
            this.BtnPocrtano.Location = new System.Drawing.Point(628, 66);
            this.BtnPocrtano.Name = "BtnPocrtano";
            this.BtnPocrtano.Size = new System.Drawing.Size(77, 33);
            this.BtnPocrtano.TabIndex = 6;
            this.BtnPocrtano.Text = "Pocrtano";
            this.BtnPocrtano.UseVisualStyleBackColor = true;
            this.BtnPocrtano.Click += new System.EventHandler(this.BtnPocrtano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPocrtano);
            this.Controls.Add(this.BtnUkoseno);
            this.Controls.Add(this.BtnBold);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnBold;
        private System.Windows.Forms.Button BtnUkoseno;
        private System.Windows.Forms.Button BtnPocrtano;
    }
}

