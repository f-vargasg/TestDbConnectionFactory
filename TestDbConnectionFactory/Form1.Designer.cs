namespace TestDbConnectionFactory
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
            this.butDo = new System.Windows.Forms.Button();
            this.gvFilesOnServer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvFilesOnServer)).BeginInit();
            this.SuspendLayout();
            // 
            // butDo
            // 
            this.butDo.Location = new System.Drawing.Point(263, 306);
            this.butDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(267, 135);
            this.butDo.TabIndex = 0;
            this.butDo.Text = "Do";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.butDo_Click);
            // 
            // gvFilesOnServer
            // 
            this.gvFilesOnServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFilesOnServer.Location = new System.Drawing.Point(9, 3);
            this.gvFilesOnServer.Name = "gvFilesOnServer";
            this.gvFilesOnServer.Size = new System.Drawing.Size(758, 280);
            this.gvFilesOnServer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 455);
            this.Controls.Add(this.gvFilesOnServer);
            this.Controls.Add(this.butDo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvFilesOnServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.DataGridView gvFilesOnServer;
    }
}

