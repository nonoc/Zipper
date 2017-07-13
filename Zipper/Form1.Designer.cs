namespace Zipper
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnComprimir = new System.Windows.Forms.Button();
            this.btnDescomprimir = new System.Windows.Forms.Button();
            this.btnPathOrigen = new System.Windows.Forms.Button();
            this.btnPathDestino = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ckSobreescribirFile = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtPathOrigen = new System.Windows.Forms.TextBox();
            this.txtPathDestino = new System.Windows.Forms.TextBox();
            this.txtMsgInfo = new System.Windows.Forms.TextBox();
            this.txtFileZip = new System.Windows.Forms.TextBox();
            this.btnFileZip = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cbMetodo = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.btnExplorer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComprimir
            // 
            this.btnComprimir.Location = new System.Drawing.Point(250, 185);
            this.btnComprimir.Name = "btnComprimir";
            this.btnComprimir.Size = new System.Drawing.Size(87, 23);
            this.btnComprimir.TabIndex = 0;
            this.btnComprimir.Text = "&Comprimir";
            this.btnComprimir.UseVisualStyleBackColor = true;
            this.btnComprimir.Click += new System.EventHandler(this.btnComprimir_Click);
            // 
            // btnDescomprimir
            // 
            this.btnDescomprimir.Location = new System.Drawing.Point(343, 183);
            this.btnDescomprimir.Name = "btnDescomprimir";
            this.btnDescomprimir.Size = new System.Drawing.Size(87, 23);
            this.btnDescomprimir.TabIndex = 1;
            this.btnDescomprimir.Text = "&Descomprimir";
            this.btnDescomprimir.UseVisualStyleBackColor = true;
            this.btnDescomprimir.Click += new System.EventHandler(this.btnDescomprimir_Click);
            // 
            // btnPathOrigen
            // 
            this.btnPathOrigen.Location = new System.Drawing.Point(401, 20);
            this.btnPathOrigen.Name = "btnPathOrigen";
            this.btnPathOrigen.Size = new System.Drawing.Size(29, 23);
            this.btnPathOrigen.TabIndex = 2;
            this.btnPathOrigen.Text = "...";
            this.btnPathOrigen.UseVisualStyleBackColor = true;
            this.btnPathOrigen.Click += new System.EventHandler(this.btnPathOrigen_Click);
            // 
            // btnPathDestino
            // 
            this.btnPathDestino.Location = new System.Drawing.Point(401, 69);
            this.btnPathDestino.Name = "btnPathDestino";
            this.btnPathDestino.Size = new System.Drawing.Size(29, 23);
            this.btnPathDestino.TabIndex = 3;
            this.btnPathDestino.Text = "...";
            this.btnPathDestino.UseVisualStyleBackColor = true;
            this.btnPathDestino.Click += new System.EventHandler(this.btnPathDestino_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ckSobreescribirFile
            // 
            this.ckSobreescribirFile.AutoSize = true;
            this.ckSobreescribirFile.Checked = true;
            this.ckSobreescribirFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSobreescribirFile.Location = new System.Drawing.Point(15, 189);
            this.ckSobreescribirFile.Name = "ckSobreescribirFile";
            this.ckSobreescribirFile.Size = new System.Drawing.Size(197, 17);
            this.ckSobreescribirFile.TabIndex = 7;
            this.ckSobreescribirFile.Text = "Sobreescribir Fichero Zip o Carpetas";
            this.ckSobreescribirFile.UseVisualStyleBackColor = true;
            this.ckSobreescribirFile.CheckedChanged += new System.EventHandler(this.ckSobreescribirFile_CheckedChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 163);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(415, 14);
            this.progressBar.TabIndex = 8;
            // 
            // txtPathOrigen
            // 
            this.txtPathOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathOrigen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPathOrigen.Location = new System.Drawing.Point(12, 21);
            this.txtPathOrigen.Name = "txtPathOrigen";
            this.txtPathOrigen.Size = new System.Drawing.Size(383, 20);
            this.txtPathOrigen.TabIndex = 9;
            this.txtPathOrigen.Text = "Seleccione un Directorio para Comprimir";
            // 
            // txtPathDestino
            // 
            this.txtPathDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathDestino.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPathDestino.Location = new System.Drawing.Point(12, 70);
            this.txtPathDestino.Name = "txtPathDestino";
            this.txtPathDestino.Size = new System.Drawing.Size(383, 20);
            this.txtPathDestino.TabIndex = 10;
            this.txtPathDestino.Text = "Seleccione un Directorio para Descomprimir";
            // 
            // txtMsgInfo
            // 
            this.txtMsgInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtMsgInfo.Location = new System.Drawing.Point(12, 92);
            this.txtMsgInfo.Multiline = true;
            this.txtMsgInfo.Name = "txtMsgInfo";
            this.txtMsgInfo.Size = new System.Drawing.Size(311, 56);
            this.txtMsgInfo.TabIndex = 11;
            this.txtMsgInfo.Text = "Proporciona informacion de estado de la compresion";
            // 
            // txtFileZip
            // 
            this.txtFileZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileZip.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFileZip.Location = new System.Drawing.Point(12, 46);
            this.txtFileZip.Name = "txtFileZip";
            this.txtFileZip.Size = new System.Drawing.Size(383, 20);
            this.txtFileZip.TabIndex = 13;
            this.txtFileZip.Text = "Seleccione un Archivo para Descomprimir";
            // 
            // btnFileZip
            // 
            this.btnFileZip.Location = new System.Drawing.Point(401, 45);
            this.btnFileZip.Name = "btnFileZip";
            this.btnFileZip.Size = new System.Drawing.Size(29, 23);
            this.btnFileZip.TabIndex = 12;
            this.btnFileZip.Text = "...";
            this.btnFileZip.UseVisualStyleBackColor = true;
            this.btnFileZip.Click += new System.EventHandler(this.btnFileZip_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // cbMetodo
            // 
            this.cbMetodo.FormattingEnabled = true;
            this.cbMetodo.Location = new System.Drawing.Point(343, 136);
            this.cbMetodo.Name = "cbMetodo";
            this.cbMetodo.Size = new System.Drawing.Size(87, 21);
            this.cbMetodo.TabIndex = 14;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(236, 139);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(101, 13);
            this.lblMetodo.TabIndex = 15;
            this.lblMetodo.Text = "Método Compresión";
            // 
            // btnExplorer
            // 
            this.btnExplorer.Location = new System.Drawing.Point(343, 94);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(87, 23);
            this.btnExplorer.TabIndex = 16;
            this.btnExplorer.Text = "Ver Resultado";
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 223);
            this.Controls.Add(this.btnExplorer);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.cbMetodo);
            this.Controls.Add(this.txtFileZip);
            this.Controls.Add(this.btnFileZip);
            this.Controls.Add(this.txtMsgInfo);
            this.Controls.Add(this.txtPathDestino);
            this.Controls.Add(this.txtPathOrigen);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ckSobreescribirFile);
            this.Controls.Add(this.btnPathDestino);
            this.Controls.Add(this.btnPathOrigen);
            this.Controls.Add(this.btnDescomprimir);
            this.Controls.Add(this.btnComprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compresor de Carpetas";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprimir;
        private System.Windows.Forms.Button btnDescomprimir;
        private System.Windows.Forms.Button btnPathOrigen;
        private System.Windows.Forms.Button btnPathDestino;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox ckSobreescribirFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtPathDestino;
        private System.Windows.Forms.TextBox txtPathOrigen;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtMsgInfo;
        private System.Windows.Forms.TextBox txtFileZip;
        private System.Windows.Forms.Button btnFileZip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cbMetodo;
        private System.Windows.Forms.Button btnExplorer;
    }
}

