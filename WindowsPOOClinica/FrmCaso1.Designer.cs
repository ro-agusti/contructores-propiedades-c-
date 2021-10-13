
namespace WindowsPOOClinica
{
    partial class FrmCaso1
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
            this.btnImprimirInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImprimirInfo
            // 
            this.btnImprimirInfo.Location = new System.Drawing.Point(129, 157);
            this.btnImprimirInfo.Name = "btnImprimirInfo";
            this.btnImprimirInfo.Size = new System.Drawing.Size(177, 45);
            this.btnImprimirInfo.TabIndex = 0;
            this.btnImprimirInfo.Text = "Imprimir info";
            this.btnImprimirInfo.UseVisualStyleBackColor = true;
            this.btnImprimirInfo.Click += new System.EventHandler(this.btnImprimirInfo_Click);
            // 
            // FrmCaso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimirInfo);
            this.Name = "FrmCaso1";
            this.Text = "FrmCaso1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimirInfo;
    }
}