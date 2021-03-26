
namespace SerialNumberHD
{
    partial class frmHDSN
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetSerialNumber = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnType = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetSerialNumber
            // 
            this.btnGetSerialNumber.Location = new System.Drawing.Point(42, 24);
            this.btnGetSerialNumber.Name = "btnGetSerialNumber";
            this.btnGetSerialNumber.Size = new System.Drawing.Size(195, 35);
            this.btnGetSerialNumber.TabIndex = 0;
            this.btnGetSerialNumber.Text = "Get Serial Number";
            this.btnGetSerialNumber.UseVisualStyleBackColor = true;
            this.btnGetSerialNumber.Click += new System.EventHandler(this.btnGetSerialNumber_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(48, 82);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 17);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model:";
            // 
            // btnType
            // 
            this.btnType.AutoSize = true;
            this.btnType.Location = new System.Drawing.Point(48, 110);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(44, 17);
            this.btnType.TabIndex = 2;
            this.btnType.Text = "Type:";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(48, 139);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(102, 17);
            this.lblSerialNumber.TabIndex = 3;
            this.lblSerialNumber.Text = "Serial Number:";
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(159, 79);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(382, 22);
            this.txtModel.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(159, 107);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(382, 22);
            this.txtType.TabIndex = 5;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Enabled = false;
            this.txtSerialNumber.Location = new System.Drawing.Point(159, 136);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(382, 22);
            this.txtSerialNumber.TabIndex = 6;
            // 
            // frmHDSN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 199);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.btnGetSerialNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHDSN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hard Drive Serial Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSerialNumber;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label btnType;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSerialNumber;
    }
}

