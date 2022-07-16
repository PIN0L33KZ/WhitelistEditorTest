using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WhitelistEditorTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            WindowTitle.Text = this.Text; //Set the Labeltext to the Formtext.
            DataGridWhitelist.ContextMenuStrip = ContextMenuStripDatagrid; //Assing the Contextmenu to the Datagrid.
            this.Refresh(); //Refresh the form.
        }

        private void ButtonAddPlayer_Click( object sender, System.EventArgs e )
        {
            //Check if Textbox is filled.
            if( TextBoxPlayerName.TextLength > 0 )
            {
                //Show a Messagebox and exit the Method when the Playername is invalid.
                if( IsPlayernameValid( TextBoxPlayerName.Text ) == false )
                {
                    MessageBox.Show( "Der eingegebene Spielername konnte nicht gefunden werden.\nBitte überprüfe deine Eingabe!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }

                #region If Playername is valid.
                WhitelistMember whitelistMember = GetWhitelistMember( TextBoxPlayerName.Text ); //Create Object to add the members into the Datagrid.

                DataGridWhitelist.Rows.Add( whitelistMember.Playername, whitelistMember.PlayerID ); //Add Object members into the Datagrid.

                DataGridWhitelist.ClearSelection(); //Clear selection on rows.

                TextBoxPlayerName.Clear(); //Clear the Text inside the Textbox.
                TextBoxPlayerName.Focus(); //Focuse the Textbox.
                #endregion
            }
            else
            {
                //Show Messagebox if textbox isn't filled.
                MessageBox.Show( "Bitte fülle das Feld 'Spielername'!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        } //Verify playername and add it into the Datagrid.

        private bool IsPlayernameValid( string playername )
        {
            WebClient webClient = new WebClient(); //Used to get the API-Response.

            try
            {
                //Use Offical API to get the Players UUID and theire 'correct' Playername casing.
                string apiResponse = webClient.DownloadString( $"https://api.mojang.com/users/profiles/minecraft/{playername}" );

                //If length of the API-Response isn't zero, get Username and Userid.
                if( apiResponse.Length > 0 )
                {
                    //Deserialize Json from API-Response.
                    WhitelistMember whitelistMember = JsonConvert.DeserializeObject<WhitelistMember>( apiResponse );

                    //If length of Playername and Playerid isn't zero, return true.
                    if( whitelistMember.Playername.Length != 0 && whitelistMember.PlayerID.Length != 0 )
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch( Exception )
            {
                //Show Messagebox if an exception is thrown.
                MessageBox.Show( "Ein fehler bei der Datenübertragung ist aufgetreten.\nBitte prüfe deine Netzverbindung.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
        } //Check if Playername exists in the database of Mojang.

        private WhitelistMember GetWhitelistMember( string playername )
        {
            WhitelistMember whitelistMember = new WhitelistMember(); //Object to return.

            WebClient webClient = new WebClient(); //Used to get the API-Response.

            try
            {
                //Use Offical API to get the Players UUID and theire 'correct' Playername casing.
                string apiResponse = webClient.DownloadString( $"https://api.mojang.com/users/profiles/minecraft/{playername}" );

                //If length of the API-Response isn't zero, get Username and Userid.
                if( apiResponse.Length > 0 )
                {
                    //Deserialize Json from API-Response.
                    whitelistMember = JsonConvert.DeserializeObject<WhitelistMember>( apiResponse );
                }
            }
            catch( Exception )
            {
                //Show Messagebox if an exception is thrown.
                MessageBox.Show( "Ein fehler bei der Datenübertragung ist aufgetreten.\nBitte prüfe deine Netzverbindung.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            return whitelistMember;
        } //Get Playname (with the right casing) and Playerid.

        private void TextBoxPlayerName_KeyDown( object sender, KeyEventArgs e )
        {
            //If user pressed the Enter key, fire the click event from the add player button.
            if( e.KeyCode == Keys.Enter )
            {
                ButtonAddPlayer.PerformClick();
                e.SuppressKeyPress = true; //Handover the event to the control Element.
            }
        } //Fire button add event while enter is pressed.

        private void RemovePlayerFromListToolStripButton_Click( object sender, EventArgs e )
        {
            foreach( DataGridViewRow selectedRow in DataGridWhitelist.SelectedRows )
            {
                DataGridWhitelist.Rows.Remove( selectedRow ); //Remove row from Datagrid
            }

            DataGridWhitelist.ClearSelection(); //Clear selection on rows.
        } //Remove Player out of the Datagrid.

        private void ButtonLoadWhitelist_Click( object sender, EventArgs e )
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog()
            {
                Title = "Von wo möchtest du deine Liste laden?",
                FileName = "Meine Whitelist",
                Filter = "Listen Datei (*.lst)|*.lst"
            };

            //Check if the datagrid alrady contains data.
            if(DataGridWhitelist.Rows.Count > 0)
            {
                //if datagrid contains data, asks user to overwrite the data.
                DialogResult userGuarantee = MessageBox.Show( "Durch das laden einer Datei werden vorhandene Daten ersetzt!\nFortfahren?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
                if(userGuarantee == DialogResult.Yes )
                {
                    #region Load Data from File
                    DataGridWhitelist.Rows.Clear(); //Remove existing rows.

                    //If user selected a file, load the data from it.
                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Whitelist.LoadWhitelistFromFile(DataGridWhitelist, saveFileDialog.FileName, Text );

                        //Show a messagebox to inform the user, that the file was loaded successfully.
                        MessageBox.Show( $"Die Datei \"{GetFilenameFromPath( saveFileDialog.FileName )}\" wurde erfolgreich geladen.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
                    }
                    #endregion
                }
                else
                    return;
            }
            else
            {
                #region Load Data from File
                //If user selected a file, load the data from it.
                if( saveFileDialog.ShowDialog() == DialogResult.OK )
                {
                    Whitelist.LoadWhitelistFromFile( DataGridWhitelist, saveFileDialog.FileName, Text );

                    //Show a messagebox to inform the user, that the file was loaded successfully.
                    MessageBox.Show( $"Die Datei \"{GetFilenameFromPath( saveFileDialog.FileName )}\" wurde erfolgreich geladen.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                #endregion
            }
        }

        private void ButtonSaveWhitelist_Click( object sender, EventArgs e )
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Wo möchtest du deine Liste speichern?",
                FileName = "Meine Whitelist.lst",
                Filter = "Listen Datei (*.lst)|*.lst"
            };

            if(saveFileDialog.ShowDialog() == DialogResult.OK )
            {
                Whitelist.SaveWhitelistToFile( DataGridWhitelist, saveFileDialog.FileName, Text );

                //Show a messagebox to inform the user, that the file was saved successfully.
                MessageBox.Show( $"Die Datei \"{GetFilenameFromPath( saveFileDialog.FileName )}\" wurde erfolgreich gespeichert.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private string GetFilenameFromPath(string path)
        {
            string[] filename = path.Split( '\\' );
            return filename[ filename.Length - 1 ];
        }

        private void ButtonExportWhitelist_Click( object sender, EventArgs e )
        {
            //Check if any player is added yet.
            if(DataGridWhitelist.Rows.Count > 0)
            {
                #region SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Title = "Wo möchtest du deine Whitelist exportieren?",
                    FileName = "Meine Whitelist.json",
                    Filter = "JSON Datei (*.json)|*.json"
                };

                if( saveFileDialog.ShowDialog() == DialogResult.OK )
                {
                    Whitelist.ExportWhitelistToFile( DataGridWhitelist, saveFileDialog.FileName, Text );

                    //Show a messagebox to inform the user, that the file was saved successfully.
                    MessageBox.Show( $"Die Datei \"{GetFilenameFromPath( saveFileDialog.FileName )}\" wurde erfolgreich exportiert.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                #endregion
               
            }
            else
            {
                //Show messagebox if no player is added yet.
                MessageBox.Show("Bitte schalte mindestens einen Spieler frei.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

    }
}