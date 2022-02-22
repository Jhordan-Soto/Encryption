
namespace CriptografiaSCD
{
  partial class Criptografia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criptografia));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEncriptar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslMenu = new System.Windows.Forms.ToolStripLabel();
            this.tsbcbMenu = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAESClaveHash = new System.Windows.Forms.TextBox();
            this.lblAESClaveHash = new System.Windows.Forms.Label();
            this.txtAESClaveSecreta = new System.Windows.Forms.TextBox();
            this.lblAESClaveSecreta = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAEncriptar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt3DesClaveHash = new System.Windows.Forms.TextBox();
            this.lbl3DesClaveHash = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEncriptar,
            this.tsbLimpiar,
            this.toolStripSeparator1,
            this.tslMenu,
            this.tsbcbMenu,
            this.toolStripSeparator4,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1448, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // tsbEncriptar
            // 
            this.tsbEncriptar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEncriptar.Image")));
            this.tsbEncriptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEncriptar.Name = "tsbEncriptar";
            this.tsbEncriptar.Size = new System.Drawing.Size(44, 44);
            // 
            // tsbLimpiar
            // 
            this.tsbLimpiar.Image = global::CriptografiaSCD.Properties.Resources.CleanData_16x;
            this.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiar.Name = "tsbLimpiar";
            this.tsbLimpiar.Size = new System.Drawing.Size(114, 44);
            this.tsbLimpiar.Text = "&Limpiar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // tslMenu
            // 
            this.tslMenu.Name = "tslMenu";
            this.tslMenu.Size = new System.Drawing.Size(123, 44);
            this.tslMenu.Text = "Clase a utilizar";
            // 
            // tsbcbMenu
            // 
            this.tsbcbMenu.Items.AddRange(new object[] {
            "AES (Rijndael)",
            "MD5",
            "TripleDES"});
            this.tsbcbMenu.Name = "tsbcbMenu";
            this.tsbcbMenu.Size = new System.Drawing.Size(136, 47);
            this.tsbcbMenu.ToolTipText = "Lista de clases para encriptar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton1.Text = "Desencriptar";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAESClaveHash);
            this.groupBox2.Controls.Add(this.lblAESClaveHash);
            this.groupBox2.Controls.Add(this.txtAESClaveSecreta);
            this.groupBox2.Controls.Add(this.lblAESClaveSecreta);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(873, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES";
            // 
            // txtAESClaveHash
            // 
            this.txtAESClaveHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAESClaveHash.Location = new System.Drawing.Point(140, 70);
            this.txtAESClaveHash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAESClaveHash.Name = "txtAESClaveHash";
            this.txtAESClaveHash.Size = new System.Drawing.Size(716, 25);
            this.txtAESClaveHash.TabIndex = 6;
            // 
            // lblAESClaveHash
            // 
            this.lblAESClaveHash.AutoSize = true;
            this.lblAESClaveHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAESClaveHash.Location = new System.Drawing.Point(40, 70);
            this.lblAESClaveHash.Name = "lblAESClaveHash";
            this.lblAESClaveHash.Size = new System.Drawing.Size(90, 20);
            this.lblAESClaveHash.TabIndex = 5;
            this.lblAESClaveHash.Text = "Clave Hash";
            // 
            // txtAESClaveSecreta
            // 
            this.txtAESClaveSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAESClaveSecreta.Location = new System.Drawing.Point(140, 34);
            this.txtAESClaveSecreta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAESClaveSecreta.Name = "txtAESClaveSecreta";
            this.txtAESClaveSecreta.Size = new System.Drawing.Size(716, 25);
            this.txtAESClaveSecreta.TabIndex = 4;
            // 
            // lblAESClaveSecreta
            // 
            this.lblAESClaveSecreta.AutoSize = true;
            this.lblAESClaveSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAESClaveSecreta.Location = new System.Drawing.Point(22, 34);
            this.lblAESClaveSecreta.Name = "lblAESClaveSecreta";
            this.lblAESClaveSecreta.Size = new System.Drawing.Size(108, 20);
            this.lblAESClaveSecreta.TabIndex = 3;
            this.lblAESClaveSecreta.Text = "Clave Secreta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResultado);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 339);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(873, 285);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.AcceptsReturn = true;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(25, 32);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(829, 233);
            this.txtResultado.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtError);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(14, 626);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(873, 200);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Excepciones";
            // 
            // txtError
            // 
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.Location = new System.Drawing.Point(26, 35);
            this.txtError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(830, 149);
            this.txtError.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAEncriptar);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(15, 259);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(872, 78);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Información a encriptar o desencriptar";
            // 
            // txtAEncriptar
            // 
            this.txtAEncriptar.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAEncriptar.Location = new System.Drawing.Point(25, 32);
            this.txtAEncriptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAEncriptar.Name = "txtAEncriptar";
            this.txtAEncriptar.Size = new System.Drawing.Size(830, 25);
            this.txtAEncriptar.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt3DesClaveHash);
            this.groupBox1.Controls.Add(this.lbl3DesClaveHash);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 179);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(873, 78);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TripleDES";
            // 
            // txt3DesClaveHash
            // 
            this.txt3DesClaveHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3DesClaveHash.Location = new System.Drawing.Point(140, 35);
            this.txt3DesClaveHash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt3DesClaveHash.Name = "txt3DesClaveHash";
            this.txt3DesClaveHash.Size = new System.Drawing.Size(715, 25);
            this.txt3DesClaveHash.TabIndex = 1;
            // 
            // lbl3DesClaveHash
            // 
            this.lbl3DesClaveHash.AutoSize = true;
            this.lbl3DesClaveHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3DesClaveHash.Location = new System.Drawing.Point(40, 35);
            this.lbl3DesClaveHash.Name = "lbl3DesClaveHash";
            this.lbl3DesClaveHash.Size = new System.Drawing.Size(90, 20);
            this.lbl3DesClaveHash.TabIndex = 0;
            this.lbl3DesClaveHash.Text = "Clave Hash";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(942, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Criptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 875);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Criptografia";
            this.Text = "Encriptacion [AES, MD5 y TripleDES]";
            this.Load += new System.EventHandler(this.Criptografia_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbEncriptar;
    private System.Windows.Forms.ToolStripButton tsbLimpiar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripLabel tslMenu;
    private System.Windows.Forms.ToolStripComboBox tsbcbMenu;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtAESClaveHash;
    private System.Windows.Forms.Label lblAESClaveHash;
    private System.Windows.Forms.TextBox txtAESClaveSecreta;
    private System.Windows.Forms.Label lblAESClaveSecreta;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.TextBox txtAEncriptar;
    private System.Windows.Forms.TextBox txtResultado;
    private System.Windows.Forms.TextBox txtError;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txt3DesClaveHash;
    private System.Windows.Forms.Label lbl3DesClaveHash;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.PictureBox pictureBox1;
    }
}

