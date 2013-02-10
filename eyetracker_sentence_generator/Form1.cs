using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eyetracker_sentence_generator
{
    public partial class Form1 : Form
    {
        private readonly string BACKGROUND_IMAGE_NAME = "background.bmp";
        private readonly string WORKING_DIRECTORY = Path.Combine(Application.StartupPath, "Generated Images");
        private readonly int IMAGE_FILE_NAME_TRUNCATE = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseSentences_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            dlgOpenFile.Title = "Select a ViewPoint Settings File...";
            dlgOpenFile.Filter = "Text Files (.txt)|*.txt";
            dlgOpenFile.Multiselect = false;
            dlgOpenFile.CheckFileExists = true;
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                txtSentencesFile.Text = dlgOpenFile.FileName;
            }
        }

        private void btnBrowseImageMagick_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgFolderBrowse = new FolderBrowserDialog();
            dlgFolderBrowse.ShowNewFolderButton = false;
            dlgFolderBrowse.Description = "Select the folder that contains ImageMagick files.";
            if (dlgFolderBrowse.ShowDialog() == DialogResult.OK)
            {
                txtImageMagickFolder.Text = dlgFolderBrowse.SelectedPath;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedCharacters = "1234567890\b";
            if (!allowedCharacters.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
                toolStripStatusLabel1.Text = "Invalid character";
            }
            else
            {
                toolStripStatusLabel1.Text = "";
            }
        }

        private void txtBackgroundColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ\b";
            if (!allowedCharacters.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
                toolStripStatusLabel1.Text = "Invalid character";
            }
            else
            {
                toolStripStatusLabel1.Text = "";
            }
        }

        private void btnBackgroundGenerate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBackgroundWidth.Text) || String.IsNullOrEmpty(txtBackgroundHeight.Text) || String.IsNullOrEmpty(txtBackgroundColor.Text))
            {
                MessageBox.Show("Please enter the required fields", "Cannot continue");
                return;
            }

            string imageFolder = WORKING_DIRECTORY;
            if (!Directory.Exists(imageFolder))
                Directory.CreateDirectory(imageFolder);

            string imagePath = Path.Combine(imageFolder, BACKGROUND_IMAGE_NAME);

            runImageMagickCommand(Path.Combine(txtImageMagickFolder.Text, "convert.exe"), String.Format("-size {0}x{1} xc:{2} \"{3}\"", txtBackgroundWidth.Text, txtBackgroundHeight.Text, txtBackgroundColor.Text, imagePath));
            if (File.Exists(imagePath))
                Process.Start(imagePath);
        }

        private void runImageMagickCommand(string binary, string arguments)
        {
            string bin = binary.Substring(binary.LastIndexOf('\\') + 1, binary.Length - binary.LastIndexOf('\\') - 1);
            int exitCode = -1;
            StringBuilder strBuilder = new StringBuilder();
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.RedirectStandardError = true;
                psi.UseShellExecute = false;
                psi.FileName = binary;
                psi.Arguments = arguments;
                psi.CreateNoWindow = true;
                Process p = new Process();
                p.StartInfo = psi;
                p.Start();
                strBuilder.Append(p.StandardError.ReadToEnd());
                if (!p.WaitForExit(10000))
                    p.Kill();
                exitCode = p.ExitCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Attempted to run ImageMagick {0}:\n{1}", bin, ex.ToString()), "Error");
            }

            // exit code of 0 indicates success
            if (exitCode != 0)
            {
                MessageBox.Show(String.Format("ImageMagick program \"{0}\" returned error exit code {1}:\n{2}", binary, exitCode, strBuilder.ToString()), "ImageMagick Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ImageMagickFolder != null)
            {
                if (Directory.Exists(Properties.Settings.Default.ImageMagickFolder))
                    txtImageMagickFolder.Text = Properties.Settings.Default.ImageMagickFolder;
            }
            if (Properties.Settings.Default.SentencesFile != null)
            {
                if (File.Exists(Properties.Settings.Default.SentencesFile))
                    txtSentencesFile.Text = Properties.Settings.Default.SentencesFile;
            }

            FontFamily[] fonts = FontFamily.Families;
            foreach (FontFamily font in fonts)
            {
                cbFonts.Items.Add(font.Name);
            }
            cbFonts.SelectedIndex = 0;

            toggleAdvancedModeControls(false);
            string[] files = Directory.GetFiles(txtImageMagickFolder.Text, "*.exe");
            if (Directory.Exists(txtImageMagickFolder.Text))
            {
                foreach (string file in files)
                {
                    cbBinary.Items.Add(file.Substring(file.LastIndexOf('\\') + 1, file.Length - file.LastIndexOf('\\') - 1));
                }
            }
            cbBinary.SelectedIndex = 0;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.ImageMagickFolder))
                Properties.Settings.Default.ImageMagickFolder = txtImageMagickFolder.Text;

            if (File.Exists(Properties.Settings.Default.SentencesFile))
                Properties.Settings.Default.SentencesFile = txtSentencesFile.Text;

            Properties.Settings.Default.Save();
        }



        private void cbAdvancedMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdvancedMode.Checked)
                toggleAdvancedModeControls(true);
            else
                toggleAdvancedModeControls(false);
        }

        private void toggleAdvancedModeControls(bool state)
        {
            if (state)
            {
                cbBinary.Enabled = true;
                txtCommandLine.Enabled = true;
                btnRun.Enabled = true;
            }
            else
            {
                cbBinary.Enabled = false;
                txtCommandLine.Enabled = false;
                btnRun.Enabled = false;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtImageMagickFolder.Text) && File.Exists(Path.Combine(txtImageMagickFolder.Text, cbBinary.SelectedItem.ToString())))
            {
                toolStripStatusLabel1.Text = "The ImageMagick directory does not exist or the binary does not exist";
                return;
            }

            runImageMagickCommand(Path.Combine(txtImageMagickFolder.Text, cbBinary.SelectedItem.ToString()), txtCommandLine.Text.Trim());
        }

        private void btnGenerateSentences_Click(object sender, EventArgs e)
        {
            string imageFolder = WORKING_DIRECTORY;
            if (!Directory.Exists(imageFolder))
                Directory.CreateDirectory(imageFolder);

            if (!File.Exists(txtSentencesFile.Text) || !Directory.Exists(txtImageMagickFolder.Text))
            {
                MessageBox.Show("Sentences file or ImageMagick directory does not exist or isn't set", "Cannot continue");
                return;
            }
            if (String.IsNullOrEmpty(cbFonts.SelectedItem.ToString()) || String.IsNullOrEmpty(txtFontSize.Text) || String.IsNullOrEmpty(txtFontColor.Text) ||
                String.IsNullOrEmpty(txtTextboxHeight.Text) || String.IsNullOrEmpty(txtTextboxWidth.Text) || String.IsNullOrEmpty(txtTextboxBackgroundColor.Text))
            {
                MessageBox.Show("Please enter the required fields", "Cannot continue");
                return;
            }


            List<string> sentences = new List<string>();
            StreamReader sr = null;
            try
            {
                string ln;
                sr = new StreamReader(txtSentencesFile.Text);
                while ((ln = sr.ReadLine()) != null)
                {
                    ln = ln.Trim();
                    if (ln.Length > 0) // skip blank lines or lines with spaces on them
                        sentences.Add(ln);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Failed to read sentences file \"{0}\":\n{1}", txtSentencesFile.Text, ex.ToString()), "Error");
                return;
            }
            finally
            {
                if (sr != null)
                    sr.Dispose();
            }
            if (File.Exists(Path.Combine(WORKING_DIRECTORY, BACKGROUND_IMAGE_NAME)) && sentences.Count > 0)
            {
                int backgroundWidth, backgroundHeight = 0;
                Bitmap backgroundBitmap = new Bitmap(Path.Combine(WORKING_DIRECTORY, BACKGROUND_IMAGE_NAME));
                backgroundHeight = backgroundBitmap.Size.Height;
                backgroundWidth = backgroundBitmap.Size.Width;
                backgroundBitmap.Dispose();
                int textboxWidth, textboxHeight = 0;
                textboxHeight = int.Parse(txtTextboxHeight.Text);
                textboxWidth = int.Parse(txtTextboxWidth.Text);

                int finalPosition = (backgroundHeight / 2) - (textboxHeight / 2);

                string programPathConvert = Path.Combine(txtImageMagickFolder.Text, "convert.exe");
                string programPathComposite = Path.Combine(txtImageMagickFolder.Text, "composite.exe");

                string backgroundImagePath = Path.Combine(WORKING_DIRECTORY, BACKGROUND_IMAGE_NAME);
                foreach (string sentence in sentences)
                {
                    string sentenceStr = Regex.Replace(sentence, "[^a-zA-Z0-9 -]", "").Trim();
                    int length = sentenceStr.Length;
                    if (length > IMAGE_FILE_NAME_TRUNCATE)
                        sentenceStr = sentenceStr.Substring(0, IMAGE_FILE_NAME_TRUNCATE);
                    string cleanSentenceFile = Path.Combine(WORKING_DIRECTORY, sentenceStr);

                    string convertArguments = String.Format("-size {0}x{1} -background \"{7}\" -gravity west -pointsize {3} -font \"{4}\" -fill \"{2}\" caption:\"{5}\" +antialias \"{6}\"",
                       txtTextboxWidth.Text, txtTextboxHeight.Text, txtFontColor.Text, txtFontSize.Text, cbFonts.SelectedItem.ToString(), sentence, cleanSentenceFile + "_cap.bmp", txtTextboxBackgroundColor.Text);

                    string compositeArguments = String.Format("-geometry +{0}+{1} \"{2}\" \"{3}\" \"{4}\"",
                        "10", finalPosition, cleanSentenceFile + "_cap.bmp", backgroundImagePath, cleanSentenceFile + ".bmp"
                        );

                    runImageMagickCommand(programPathConvert, convertArguments);
                    runImageMagickCommand(programPathComposite, compositeArguments);

                    // clean up intermediary files
                    File.Delete(cleanSentenceFile + "_cap.bmp");
                }
                string lastSentenceStr = Regex.Replace(sentences[sentences.Count - 1], "[^a-zA-Z0-9 -]", "").Trim();
                if (lastSentenceStr.Length > IMAGE_FILE_NAME_TRUNCATE)
                    lastSentenceStr = lastSentenceStr.Substring(0, IMAGE_FILE_NAME_TRUNCATE);
                string lastCleanSentenceFile = Path.Combine(WORKING_DIRECTORY, lastSentenceStr) + ".bmp";


                if (File.Exists(lastCleanSentenceFile))
                    Process.Start(lastCleanSentenceFile);
            }
        }
    }
}
