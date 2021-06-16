
namespace Comentarios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comentarioTxt = new System.Windows.Forms.TextBox();
            this.enviarBtn = new System.Windows.Forms.Button();
            this.cuerpo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comentarioTxt
            // 
            this.comentarioTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comentarioTxt.BackColor = System.Drawing.SystemColors.GrayText;
            this.comentarioTxt.ForeColor = System.Drawing.SystemColors.Info;
            this.comentarioTxt.Location = new System.Drawing.Point(146, 685);
            this.comentarioTxt.Multiline = true;
            this.comentarioTxt.Name = "comentarioTxt";
            this.comentarioTxt.Size = new System.Drawing.Size(983, 35);
            this.comentarioTxt.TabIndex = 1;
            // 
            // enviarBtn
            // 
            this.enviarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.enviarBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.enviarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enviarBtn.BackgroundImage")));
            this.enviarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enviarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enviarBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enviarBtn.Location = new System.Drawing.Point(1185, 676);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(89, 55);
            this.enviarBtn.TabIndex = 2;
            this.enviarBtn.UseVisualStyleBackColor = false;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // cuerpo
            // 
            this.cuerpo.AutoSize = true;
            this.cuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuerpo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuerpo.Location = new System.Drawing.Point(77, 96);
            this.cuerpo.Name = "cuerpo";
            this.cuerpo.Size = new System.Drawing.Size(51, 16);
            this.cuerpo.TabIndex = 2;
            this.cuerpo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "COMENTARIOS";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "Por likes",
            "Por antiguedad"});
            this.listBox1.Location = new System.Drawing.Point(1126, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 23);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(1074, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Orden:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(1256, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de usuario:";
            // 
            // userTxt
            // 
            this.userTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userTxt.BackColor = System.Drawing.SystemColors.GrayText;
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.userTxt.Location = new System.Drawing.Point(1405, 28);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(112, 21);
            this.userTxt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1535, 752);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuerpo);
            this.Controls.Add(this.enviarBtn);
            this.Controls.Add(this.comentarioTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Programa comentarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox comentarioTxt;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.Label cuerpo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTxt;
    }
}

