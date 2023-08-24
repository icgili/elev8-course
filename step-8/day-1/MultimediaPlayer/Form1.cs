using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace MultimediaPlayer
{
    public partial class Form1 : Form
    {
        private SQLiteConnection dbConnection;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            dbConnection = new SQLiteConnection("Data Source=playlist.db;Version=3;");
            dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Playlist (ID INTEGER PRIMARY KEY, Title TEXT, FilePath TEXT)", dbConnection))
            {
                command.ExecuteNonQuery();
            }

            RefreshPlaylist();
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                // Extract file information and insert into the database
                string fileName = System.IO.Path.GetFileName(file);
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Playlist (Title, FilePath) VALUES (@Title, @FilePath)", dbConnection))
                {
                    command.Parameters.AddWithValue("@Title", fileName);
                    command.Parameters.AddWithValue("@FilePath", file);
                    command.ExecuteNonQuery();
                }
            }

            RefreshPlaylist();
        }

        private void RefreshPlaylist()
        {
            listBoxPlaylist.Items.Clear();

            using (SQLiteCommand command = new SQLiteCommand("SELECT ID, Title FROM Playlist", dbConnection))
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listBoxPlaylist.Items.Add(reader["ID"] + "-" + reader["Title"]);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(listBoxPlaylist.SelectedIndex == -1)
            {
                MessageBox.Show("There is no song selected!");
                return;
            }

            string selectedId = listBoxPlaylist.SelectedItem.ToString().Split('-')[0].Trim();

            using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Playlist WHERE ID = @Id", dbConnection))
            {
                command.Parameters.AddWithValue("@Id", selectedId);
                command.ExecuteNonQuery();
            }

            RefreshPlaylist();
        }
    }
}
