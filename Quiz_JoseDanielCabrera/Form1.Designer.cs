
namespace Quiz_JoseDanielCabrera
{
    partial class Axie_Infinity_Blockchain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Axie_Infinity_Blockchain));
            this.TitleApp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wallet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.AxieType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pureza = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.TitleApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pureza)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleApp
            // 
            this.TitleApp.BackColor = System.Drawing.Color.Transparent;
            this.TitleApp.Image = ((System.Drawing.Image)(resources.GetObject("TitleApp.Image")));
            this.TitleApp.Location = new System.Drawing.Point(-63, -7);
            this.TitleApp.Name = "TitleApp";
            this.TitleApp.Size = new System.Drawing.Size(357, 212);
            this.TitleApp.TabIndex = 0;
            this.TitleApp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(82, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dirección Wallet";
            // 
            // Wallet
            // 
            this.Wallet.Location = new System.Drawing.Point(51, 263);
            this.Wallet.Name = "Wallet";
            this.Wallet.Size = new System.Drawing.Size(230, 20);
            this.Wallet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(80, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de registro";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(51, 345);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(234, 20);
            this.Fecha.TabIndex = 4;
            // 
            // AxieType
            // 
            this.AxieType.FormattingEnabled = true;
            this.AxieType.Items.AddRange(new object[] {
            "Beast",
            "Plant",
            "Bug",
            "Mech",
            "Dusk",
            "Aquatic",
            "Bird",
            "Reptile",
            "Dawn"});
            this.AxieType.Location = new System.Drawing.Point(112, 428);
            this.AxieType.Name = "AxieType";
            this.AxieType.Size = new System.Drawing.Size(121, 21);
            this.AxieType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(120, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(132, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado";
            // 
            // Pureza
            // 
            this.Pureza.Location = new System.Drawing.Point(73, 608);
            this.Pureza.Maximum = 6;
            this.Pureza.Minimum = 1;
            this.Pureza.Name = "Pureza";
            this.Pureza.Size = new System.Drawing.Size(194, 45);
            this.Pureza.TabIndex = 9;
            this.Pureza.Value = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(132, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pureza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(422, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Historial de transacciones";
            // 
            // rtxtResults
            // 
            this.rtxtResults.Location = new System.Drawing.Point(422, 265);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(264, 129);
            this.rtxtResults.TabIndex = 12;
            this.rtxtResults.Text = "";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.Location = new System.Drawing.Point(415, 400);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(136, 36);
            this.Add.TabIndex = 13;
            this.Add.Text = "Añadir";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Report.Location = new System.Drawing.Point(557, 400);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(136, 36);
            this.Report.TabIndex = 14;
            this.Report.Text = "Reporte";
            this.Report.UseVisualStyleBackColor = false;
            // 
            // Estado
            // 
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Huevo",
            "Adulto"});
            this.Estado.Location = new System.Drawing.Point(113, 506);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(120, 43);
            this.Estado.TabIndex = 15;
            // 
            // Axie_Infinity_Blockchain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pureza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AxieType);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Wallet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Axie_Infinity_Blockchain";
            this.Text = "Axie Infinity Blockchain";
            ((System.ComponentModel.ISupportInitialize)(this.TitleApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pureza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TitleApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Wallet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.ComboBox AxieType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar Pureza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.ListBox Estado;
    }
}

