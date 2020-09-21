/*
    Project:    LOL Language Application
    Date:       September 2020
    Programmer: Cosmos/From The Cosmos/FromTheCosmos               
    Allows users to specify the League of Legends
    client language prior to client launch. First Release.
    Known bugs: None
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LOL_Language
{
    public partial class LLForm : Form
    {

        // Default client path of Riot Games League of Legends installation
        public string defaultClientPath = "C:/Riot Games/League of Legends/LeagueClient.exe";

        public string clientPath = string.Empty;

        public LLForm()
        {
            InitializeComponent();
            loadComboBox();
            setClientPath();
        }

        private void loadComboBox()
        {

            try
            {
                languageComboBox.DisplayMember = "KEY";
                languageComboBox.ValueMember = "VALUE";


                // Creates usable dictionary to manage the different client locales
                IDictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("English (US)", "en_US");
                dictionary.Add("English (OCE)", "en_AU");
                dictionary.Add("English (EUW)", "en_GB");
                dictionary.Add("English (EUNE)", "en_PL");
                dictionary.Add("Español (EUW)", "es_ES");
                dictionary.Add("Español (LAN)", "es_MX");
                dictionary.Add("Español (LAS)", "es_AR");
                dictionary.Add("Română", "ro_RO");
                dictionary.Add("Français", "fr_FR");
                dictionary.Add("Русский", "ru_RU");
                dictionary.Add("Português", "pt_BR");
                dictionary.Add("Türkçe", "tr_TR");
                dictionary.Add("Deutsch", "de_DE");
                dictionary.Add("Ελληνικά", "el_GR");
                dictionary.Add("Italiano", "it_IT");
                dictionary.Add("Magyar", "hu_HU");
                dictionary.Add("Polski", "pl_PL");
                dictionary.Add("Čeština", "cs_CZ");
                dictionary.Add("汉字", "zh_CN");
                dictionary.Add("日本語", "ja_JP");
                dictionary.Add("한국어", "ko_KR");

                languageComboBox.DataSource = new BindingSource(dictionary, null);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to load locales due to fatal error:\n" + exception.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method is used to check for the LeagueClient.exe file using the defaultPath variable
        // If found the clientPath is set so no additional action is required by the user. If no
        // file is found, a new button appears forcing the user to manually find LeagueClient.exe
        private void setClientPath()
        {
            try
            {
                if (File.Exists(defaultClientPath))
                {
                    clientPath = defaultClientPath;
                    clientButton.Visible = false;
                }
                else
                {
                    clientLabel.Text = "League of Legends\n installation not found!";
                    clientLabel.ForeColor = Color.Red;
                    playButton.Visible = false;
                    languageComboBox.Visible = false;
                    dragAndDropLabel.Visible = true;
                    dragAndDropLabel.Text = "Click the button above or drag\n a LeagueClient.exe\n (or shortcut) file here!";
                    dragAndDropLabel.ForeColor = Color.FromArgb(78, 184, 206);
                    this.AllowDrop = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to set client path due to error:\n" + exception.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Sets what the arguments are for the process assigned to variable
                string locale = "--locale=" + languageComboBox.SelectedValue.ToString();

                // Starts the LeagueClient.exe assuming the path was set successfully using locale as arguments
                Process.Start(clientPath, locale);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to launch client due to error: \n" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientButton_Click(object sender, EventArgs e)
        {

            try
            {


                var initialDir = "C:\\Riot Games\\League of Legends\\";

                if (Directory.Exists(initialDir))
                {
                    // Sets initial directory for what the common installation path of the LeagueClient.exe is
                    openFileDialog.InitialDirectory = "C:\\Riot Games\\League of Legends\\";
                }
                else
                {
                    openFileDialog.InitialDirectory = "";
                }

                // FileName of LeagueClient.exe
                openFileDialog.FileName = "LeagueClient";

                // Filters the openFileDialog so that onle .exe files are visible
                openFileDialog.Filter = "Executable Files (.exe)|*.exe";
                openFileDialog.FilterIndex = 1;

                // Checks for when user selects and opens the file.
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    enablePlayButton(openFileDialog.FileName);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Unable to load locales due to fatal error:\n" + exception.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method handles enabling of play button and setting of client path
        // Following a click and drag file event or manual selection of file
        // Through file browser
        private void enablePlayButton(string path)
        {
            try
            {
                // Verifies the opened file is the correct filename (It should never be different than LeagueClient.exe unless
                // Riot updates the name for the executable. Also checks for .lnk files used for shortcuts. Any shortcut files
                // That do not contain "LeagueClient" are not considered. 
                if (File.Exists(path) && (path.Contains("LeagueClient.exe")
                    || (path.Contains(".lnk") && path.Contains("LeagueClient"))))
                {
                    // Sets client path to the path of the file opened
                    clientPath = path;

                    // Informs user client was set successfully
                    clientLabel.Text = "League Client set!";
                    clientLabel.ForeColor = Color.FromArgb(78, 184, 206);
                    playButton.Visible = true;
                    languageComboBox.Visible = true;
                    clientButton.Visible = false;
                    this.AllowDrop = false;
                    dragAndDropLabel.Visible = false;
                }
                else
                {
                    clientLabel.Text = "Not a valid LeagueClient.exe \nor shortcut file!";

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to set client path due to error:\n" + exception.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void exitLabel_Click(object sender, EventArgs e)
        {
            // Program exit
            this.Close();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Removes highlight selection of combobox text and shifts focus to play button.
            playButton.Focus();
        }



        // Variables to assist with click and drag relocation
        private bool mouseDown;
        private Point lastLocation;




        // Methods to allow click and drag functionality of the form
        private void LLForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void LLForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LLForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LLForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        // Handles processing of file(s) dragged into the form by the user
        private void LLForm_DragDrop(object sender, DragEventArgs e)
        {
            try
            {

                // List of files contained in the click and drag
                string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop, false);

                // Makes sure it only attempts to enable play button if only one file is
                // dragged onto the form
                if (files.Length == 1)
                {
                    enablePlayButton(files[0]);
                }
                else
                {
                    clientLabel.Text = "Dragging multiple files\n is not allowed!";
                }
            } 
            catch (InvalidCastException)
            {
                clientLabel.Text = "File not supported!";
            }
        }

    }
}
