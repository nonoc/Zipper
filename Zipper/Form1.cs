using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Ionic.Zip;
using System.IO;
using Ionic.Zlib;
using System.Diagnostics;

namespace Zipper
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Tipo de compresion
        // Ionic.Zlib.CompressionLevel.None =0
        // Ionic.Zlib.CompressionLevel.BestSpeed = 1;
        // Ionic.Zlib.CompressionLevel.Default = 6
        // Ionic.Zlib.CompressionLevel.BestCompression=9
        // 
        /// </summary>
        enum CompresionLevel
        {
            Ninguna = 0,
            Velocidad = 1,
            Normal = 6,
            Compresion = 9
        };

        public frmMain()
        {
            InitializeComponent();
            folderBrowserDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;

            //Rellenamos el combo y por defecto aplicamos el metodo normal de compresion
            cbMetodo.DataSource = Enum.GetValues(typeof(CompresionLevel));
            cbMetodo.SelectedIndex = cbMetodo.FindString("Normal");
        }

        /// <summary>
        /// Llamada a la accion para Comprimir una carpeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprimir_Click(object sender, EventArgs e)
        {
            string ZipFileToCreate = txtPathOrigen.Text + ".zip"; ;

            if (!System.IO.Directory.Exists(txtPathOrigen.Text)) { 
                errorProvider.SetError(txtPathOrigen, "Por favor seleccione un Directorio");
                return;
            }

            EnabledControlForm(false);
            using (ZipFile zip = new ZipFile())
            {

                zip.CompressionLevel = CheckMetodoCompresion();
                zip.SaveProgress += SaveProgress;

                zip.StatusMessageTextWriter = System.Console.Out;
                zip.AddDirectory(txtPathOrigen.Text);              

                zip.Save(ZipFileToCreate);
            }
            EnabledControlForm(true);

        }

        private CompressionLevel CheckMetodoCompresion()
        {
            return (Ionic.Zlib.CompressionLevel)Enum.Parse(typeof(Ionic.Zlib.CompressionLevel), 
                ConvertMetodo(cbMetodo.SelectedItem.ToString()));
        }

        // Ionic.Zlib.CompressionLevel.None =0
        // Ionic.Zlib.CompressionLevel.BestSpeed = 1;
        // Ionic.Zlib.CompressionLevel.Default = 6
        // Ionic.Zlib.CompressionLevel.BestCompression=9
        //----------------------------------------------
        // Ninguna = 0,
        // Velocidad = 1,
        // Normal = 6,
        // Compresion = 9
        /// <summary>
        /// Convierte del enumerado del Componente menos amigable a otro enumerable más facil de entender
        /// </summary>
        /// <param name="selectedItem"></param>
        /// <returns></returns>
        private string ConvertMetodo(string selectedItem)
        {
            switch (selectedItem)
            {
                case "Ninguna":
                    return "None";                    
                case "Velocidad":
                    return "BestSpeed";
                case "Normal":
                    return "Default";
                case "Compresion":
                    return "BestCompression";
                default:
                    return "Default";
            }
        }

        /// <summary>
        /// Llamada a la accion para seleccionar el fichero zip para descomprimir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileZip_Click(object sender, EventArgs e)
        {       

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txtFileZip.Text = openFileDialog.FileName;
        }

        /// <summary>
        /// Llamada a la accion de Descompresion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescomprimir_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (!System.IO.File.Exists(txtFileZip.Text))
            {
                errorProvider.SetError(txtFileZip, "Por favor seleccione un archivo válido");
                return;
            }

            if (!System.IO.Directory.Exists(txtPathDestino.Text))
            {
                errorProvider.SetError(txtPathDestino, "Por favor seleccione un Directorio");
                return;
            }

            EnabledControlForm(false);
            using (ZipFile zip = ZipFile.Read(txtFileZip.Text))
            {
                zip.CompressionLevel = CheckMetodoCompresion();
                zip.ExtractProgress += ExtractProgress;

                zip.StatusMessageTextWriter = System.Console.Out;
                zip.ExtractAll(txtPathDestino.Text, SobreescribirFicheros());
            }
            EnabledControlForm(true);
        }

        private ExtractExistingFileAction SobreescribirFicheros()
        {
            if(ckSobreescribirFile.Checked)
                return ExtractExistingFileAction.OverwriteSilently;
            else
                return ExtractExistingFileAction.DoNotOverwrite;
        }

        private void EnabledControlForm(bool estado)
        {
            btnComprimir.Enabled = estado;
            btnDescomprimir.Enabled = estado;
            btnFileZip.Enabled = estado;
            btnPathDestino.Enabled = estado;
            btnPathOrigen.Enabled = estado;
            cbMetodo.Enabled = estado;
            ckSobreescribirFile.Enabled = estado;
            btnExplorer.Enabled = estado;
        }

        /// <summary>
        /// Guarda el progreso de la accion de Descompresion y da funcionalidad a la barra de progreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Extracting_BeforeExtractAll)
            {
                txtMsgInfo.Text = "Descomprimiendo: " + e.ArchiveName;
            }
            else if (e.EventType == ZipProgressEventType.Extracting_BeforeExtractEntry)
            {
                txtMsgInfo.Text = "Escribiendo: " + e.CurrentEntry.FileName + " (" + (e.EntriesExtracted + 1) + "/" + e.EntriesTotal + ")";

                progressBar.Maximum = e.EntriesTotal;
                progressBar.Value = e.EntriesExtracted + 1;
            }
            else if (e.EventType == ZipProgressEventType.Extracting_EntryBytesWritten)
            {
                //progressBar.Value = (int)(((e.BytesTransferred * 100) / e.TotalBytesToTransfer)/ progressBar.Maximum);
            }
            else if (e.EventType == ZipProgressEventType.Extracting_AfterExtractAll)
            {
                txtMsgInfo.Text = "Hecho: " + e.ArchiveName + " - Número de archivos: " + progressBar.Value;
            }
        }


        /// <summary>
        /// Guarda el progreso de la accion de compresion y da funcionalidad a la barra de progreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_Started)
            {
                txtMsgInfo.Text = "Comprimiendo: " + e.ArchiveName;
            }
            else if (e.EventType == ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                txtMsgInfo.Text = "Escribiendo: " + e.CurrentEntry.FileName + " (" + (e.EntriesSaved + 1) + "/" + e.EntriesTotal + ")";

                progressBar.Maximum = e.EntriesTotal;
                progressBar.Value = e.EntriesSaved + 1;
            }
            else if (e.EventType == ZipProgressEventType.Saving_EntryBytesRead)
            {
                //progressBar.Value = (int)(((e.BytesTransferred * 100) / e.TotalBytesToTransfer)/ progressBar.Maximum);
            }
            else if (e.EventType == ZipProgressEventType.Saving_Completed)
            {
                txtMsgInfo.Text = "Hecho: " + e.ArchiveName + " - Número de archivos: " + progressBar.Value;
            }
        }

        /// <summary>
        /// Llamada para seleccionar la carpeta de origen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPathOrigen_Click(object sender, EventArgs e)
        {          
            txtPathOrigen.Text = SetFolderWork("PrevPathOrigen");
        }

        /// <summary>
        /// Llamada para seleccionar la carpeta de destino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPathDestino_Click(object sender, EventArgs e)
        {
           txtPathDestino.Text = SetFolderWork("PrevPathDestino");
        }

        /// <summary>
        /// Check para sobreercribir el archivo zip si existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckSobreescribirFile_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Nos permite mostrar un cuadro de dialogo para seleccionar directorio
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string SetFolderWork(string path)
        {

            if (ConfigurationManager.AppSettings[path].ToString() != "")
                folderBrowserDialog.SelectedPath = ConfigurationManager.AppSettings[path].ToString();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {  
                ConfigurationManager.AppSettings[path] = folderBrowserDialog.SelectedPath;
            }
            return ConfigurationManager.AppSettings[path].ToString();
        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe",txtPathDestino.Text);
        }
    }

}
