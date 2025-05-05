namespace Yapay_Sinir_Ağları
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearGrid;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnTrain
            this.btnTrain.Location = new System.Drawing.Point(200, 250);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(120, 30);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "Ağı Eğit";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);

            // btnRecognize
            this.btnRecognize.Location = new System.Drawing.Point(200, 290);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(120, 30);
            this.btnRecognize.TabIndex = 1;
            this.btnRecognize.Text = "Tanı";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);

            // lblError
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(200, 330);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(91, 20);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Hata oranı: ?";

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(200, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnClearGrid
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnClearGrid.Location = new System.Drawing.Point(50, 370);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(120, 30);
            this.btnClearGrid.Text = "Çizgileri Kaldır";
            this.btnClearGrid.UseVisualStyleBackColor = true;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            this.Controls.Add(this.btnClearGrid);


            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnTrain);
            this.Name = "MainForm";
            this.Text = "Harf Tanıma - YSA / Duygu Altunay";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

