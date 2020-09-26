using SharpCompress.Archive;
using SharpCompress.Common;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace UniRar_Z
{
    public partial class Form1 : Form
    {
        private CultureInfo ci;
        private string[] zipLocation;
        private string selectedPath;
        private BackgroundWorker bW;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadCmpressedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void extractDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            extractData();
        }

        private void closeUniRarZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UniRar Z - copyright 2015, Alessandro Gaggia\n\nFree to use, thanks to SharpCompress library for decompressing capabilities.\nSharpCompress.dll:\nhttps://sharpcompress.codeplex.com/\nAll rights to respective owners.");
        }

        private void loadBTN_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void extractBTN_Click(object sender, EventArgs e)
        {
            extractData();
        }

        private void loadData() 
        {
            listView.Items.Clear();
            selectedPath = "";

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Compressed Archives (*.zip;*.rar;*.tar;*.tar.gz;*.7z)|*.zip;*.rar;*.tar;*.tar.gz;*.7z|All files (*.*)|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                zipLocation = ofd.FileNames;
                foreach (string zip in zipLocation) {
                    FileInfo fi = new FileInfo(zip);
                    ListViewItem lvi = new ListViewItem(new string[]{zip, HumanReadableSize(fi.Length), fi.Extension});
                    lvi.ImageIndex = 1;
                    listView.Items.Add(lvi);
                }
            }
            ofd.Dispose();
        }

        private void extractData() {
            if (zipLocation.Length > 0) 
            {
                progressBar.Value = 0;

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if(fbd.ShowDialog() == DialogResult.OK) 
                {
                    selectedPath = fbd.SelectedPath;

                    ci = new CultureInfo(localeCombobox.Text.Split(new string[] { " : " }, StringSplitOptions.None)[1].Trim());

                    bW = new BackgroundWorker
                    {
                        WorkerReportsProgress = true,
                        WorkerSupportsCancellation = true
                    };
                    bW.DoWork += new DoWorkEventHandler(bW_DoWork);
                    bW.ProgressChanged += new ProgressChangedEventHandler(bW_ProgressChanged);
                    bW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bW_RunWorkerCompleted);
                    bW.RunWorkerAsync();
                }
                fbd.Dispose();
            }
            else
            {
                MessageBox.Show("Select at least one compressed archive.");
            }
        }

        private void bW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = progressBar.Maximum;
            MessageBox.Show("File Extracted successfully.");
        }

        private void bW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value += 1;
        }

        private void bW_DoWork(object sender, DoWorkEventArgs e)
        {
            Application.CurrentCulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            BackgroundWorker worker = sender as BackgroundWorker;
            foreach (string currentZip in zipLocation)
            {
                if (worker.CancellationPending == false)
                {
                    int count = ArchiveFactory.Open(currentZip).Entries.Count();
                    this.Invoke((MethodInvoker)delegate
                    {
                        progressBar.Maximum = count;
                        progressBar.Value = 0;
                    });


                    using (Stream stream = System.IO.File.OpenRead(currentZip))
                    {
                        var reader = ArchiveFactory.Open(stream);
                        foreach (var entry in reader.Entries)
                        {
                            if (!entry.IsDirectory)
                            {
                                entry.WriteToDirectory(selectedPath, ExtractOptions.ExtractFullPath | ExtractOptions.Overwrite);
                            }
                            worker.ReportProgress(0);
                        }
                    }

                    this.Invoke((MethodInvoker)delegate
                    {
                        foreach (ListViewItem lvi in listView.Items)
                        {
                            if (lvi.Text == currentZip)
                            {
                                lvi.ImageIndex = 0;
                            }
                        }
                    });
                }
                else {
                    
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Operation aborted.");                   
                    });
                    return;
                }
            }
        }

        private string HumanReadableSize(long bytes) {
            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len /= 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (bW != null)
                bW.CancelAsync();
        }        
    }
}
