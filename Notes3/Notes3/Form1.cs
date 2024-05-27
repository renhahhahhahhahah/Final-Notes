using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
namespace Notes3
{
    public partial class Form1 : Form
    {
        private class Data
        {
            public string Title { get; set; }
            public string Notes { get; set; }
        }
        List<Data> rows = new List<Data>();
        DataTable notes = new DataTable();
        bool editing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            if (File.Exists("datanotes.json"))
            {
                var filejson = File.ReadAllText("datanotes.json");
                var storage = JsonSerializer.Deserialize<List<Data>>(filejson);

                if (storage != null)
                {
                    foreach (var item in storage)
                    {
                        notes.Rows.Add(item.Title, item.Notes);
                    }
                }
            }

            previousnotes.DataSource = notes;
        }
       


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousnotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Not a valid note"); }
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if(previousnotes.CurrentCell != null)
            {
                TxtBxTitle.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                TxtBxNotes.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[1].ToString();

                editing = true;
            }
        }
        private void NewNotesBtn_Click(object sender, EventArgs e)
        {
            TxtBxTitle.Text = "";
            TxtBxNotes.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousnotes.CurrentCell.RowIndex]["Title"] = TxtBxTitle.Text;
                notes.Rows[previousnotes.CurrentCell.RowIndex]["Note"] = TxtBxNotes.Text;

            }
            else 
            {
                notes.Rows.Add(TxtBxTitle.Text, TxtBxNotes.Text);
                
            }
            TxtBxTitle.Text = "";
            TxtBxNotes.Text = "";
            editing = false;
        }

        private void previousnotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void previousnotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < notes.Rows.Count)
            {
                TxtBxTitle.Text = notes.Rows[e.RowIndex]["Title"].ToString();
                TxtBxNotes.Text = notes.Rows[e.RowIndex]["Note"].ToString();
                editing = true;
            }
                //TxtBxTitle.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                //TxtBxNotes.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[1].ToString();

                //editing = true;
        }

            private void Exitbtn_Click(object sender, EventArgs e)
        {

            List<Data> rows = new List<Data>();

            foreach (DataRow row in notes.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    rows.Add(new Data
                    {
                        Title = row["Title"].ToString(),
                        Notes = row["Note"].ToString()
                    });
                }
            }

            var option = new JsonSerializerOptions();

            option.WriteIndented = true;

            string json = JsonSerializer.Serialize(rows, option);
            File.WriteAllText("datanotes.json", json);

            Environment.Exit(Environment.ExitCode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
