using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WhitelistEditorTest
{
    public class Whitelist
    {
        public static void ExportWhitelistToFile(DataGridView dataGridView, string path, string formTitle)
        {
            List<WhitelistMember> whitelistMembers = new List<WhitelistMember>();

            #region Add all Rows as member to the list.
            for( int i = 0; i < dataGridView.Rows.Count; i++ )
            {
                WhitelistMember whitelistMember = new WhitelistMember
                {
                    Playername = dataGridView.Rows[ i ].Cells[ 0 ].Value.ToString(),
                    PlayerID = dataGridView.Rows[ i ].Cells[ 1 ].Value.ToString()
                }; //Create member object to add to the list.

                whitelistMembers.Add( whitelistMember ); //Add the object to the list.
            }
            #endregion

            #region Prepare Json-String to write into a file.
            string jsonString = JsonConvert.SerializeObject( whitelistMembers, Formatting.Indented ); //Serialize Objectlist into a json string

            jsonString = jsonString.Replace( "id", "uuid" ); //Minecraft servers needs the uuid key instead of the id key.

            dataGridView.ClearSelection(); //Clear selection on rows.
            #endregion

            try
            {
                //Write the json string into a file.
                File.WriteAllText( path, jsonString );
            }
            catch( Exception ex )
            {
                MessageBox.Show( $"Bei dem Exportvorgang ist ein Fehler aufgetreten:\n{ex.Message}", formTitle, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        public static void SaveWhitelistToFile( DataGridView dataGridView, string path, string formTitle )
        {
            string textToWrite = string.Empty;

            //Cycle through all Rows
            for( int i = 0; i < dataGridView.Rows.Count; i++ )
            {
                //Cycle throug all Cells
                for( int j = 0; j < dataGridView.Rows[ i ].Cells.Count; j++ )
                {
                    //When the value of the cell isn't empty add it to the final string with an ':' as a separator, else add '-' to the final string.
                    if( dataGridView.Rows[ i ].Cells[ j ].Value.ToString() != "" )
                        textToWrite += dataGridView.Rows[ i ].Cells[ j ].Value.ToString() + ":";
                    else
                        textToWrite += "-" + ":";
                }

                textToWrite = textToWrite.Remove( textToWrite.Length - 1, 1 ); //Remove the last separator.

                if( dataGridView.Rows[ i ].Index != dataGridView.Rows.Count - 1 )
                    textToWrite += Environment.NewLine; //Add a new line for a better overview.
            }

            try
            {
                File.WriteAllText( path, textToWrite ); //Save the final string into a file.
            }
            catch( Exception ex )
            {
                MessageBox.Show( $"Bei dem Speichervorgang ist ein Fehler aufgetreten:\n{ex.Message}", formTitle, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        public static void LoadWhitelistFromFile( DataGridView dataGridView, string path, string formTitle )
        {
            string[] textToRead;

            try
            {
                textToRead = File.ReadAllLines( path ); //Save all lines of the file inside an string array.

                for( int i = 0; i < textToRead.Length; i++ )
                {
                    string[] rowData = textToRead[ i ].Split( ':' ); //Split the string at the separator.

                    dataGridView.Rows.Add( rowData ); //Add the data to the Datagrid rows.
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show( $"Bei dem Ladevorgang ist ein Fehler aufgetreten:\n{ex.Message}", formTitle, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }

    public class WhitelistMember
    {
        [JsonProperty("name")]
        public string Playername { get; set; }
        [JsonProperty("id")]
        public string PlayerID { get; set; }
    }
}