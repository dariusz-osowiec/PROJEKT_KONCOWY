using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjektKoncowy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void REFRESH_Click(object sender, EventArgs e)
        {
            //ciag polaczenia do bazy i tabeli
            string strcon = "Data Source=(local)\\sqlexpress;Initial Catalog=SkladPomiarow; Integrated Security=True";
            //Dostosować nazwę bazy danych bazaPomiarów do nazwy własnej bazy!
            //polaczenie z bazą
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            // Tworzy data adapter
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Pomiary", con);
            // Uzywa DataAdapter do wypelnienia DataTable
            DataTable t = new DataTable();
            a.Fill(t);//wypelnienie danymi
            // wyswietlenie danych
            dataGridView1.DataSource = t;
            //zwolnienienie danych
            a.Dispose();
            t.Dispose();
            //zamkniecie polaczenia
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ciag polaczenia do bazy i tabeli
            string strcon = "Data Source=(local)\\sqlexpress;Initial Catalog=SkladPomiarow; Integrated Security=True";
            //Dostosować nazwę bazy danych bazaPomiarów do nazwy własnej bazy!
            //polaczenie z bazą
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            // Tworzy data adapter
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Pomiary WHERE Symulator='SIM1'", con);
            // Uzywa DataAdapter do wypelnienia DataTable
            DataTable t = new DataTable();
            a.Fill(t);//wypelnienie danymi
            // wyswietlenie danych
            dataGridView1.DataSource = t;
            //zwolnienienie danych
            a.Dispose();
            t.Dispose();
            //zamkniecie polaczenia
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ciag polaczenia do bazy i tabeli
            string strcon = "Data Source=(local)\\sqlexpress;Initial Catalog=SkladPomiarow; Integrated Security=True";
            //Dostosować nazwę bazy danych bazaPomiarów do nazwy własnej bazy!
            //polaczenie z bazą
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            // Tworzy data adapter
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Pomiary WHERE Symulator='SIM2'", con);
            // Uzywa DataAdapter do wypelnienia DataTable
            DataTable t = new DataTable();
            a.Fill(t);//wypelnienie danymi
            // wyswietlenie danych
            dataGridView1.DataSource = t;
            //zwolnienienie danych
            a.Dispose();
            t.Dispose();
            //zamkniecie polaczenia
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ciag polaczenia do bazy i tabeli
            string strcon = "Data Source=(local)\\sqlexpress;Initial Catalog=SkladPomiarow; Integrated Security=True";
            //Dostosować nazwę bazy danych bazaPomiarów do nazwy własnej bazy!
            //polaczenie z bazą
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            // Tworzy data adapter
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Pomiary WHERE Symulator='SIM3'", con);
            // Uzywa DataAdapter do wypelnienia DataTable
            DataTable t = new DataTable();
            a.Fill(t);//wypelnienie danymi
            // wyswietlenie danych
            dataGridView1.DataSource = t;
            //zwolnienienie danych
            a.Dispose();
            t.Dispose();
            //zamkniecie polaczenia
            con.Close();
        }

        private void DELETE_DATA_Click(object sender, EventArgs e)
        {
            //ciag polaczenia do bazy i tabeli
            string strcon = "Data Source=(local)\\sqlexpress;Initial Catalog=SkladPomiarow; Integrated Security=True";
            //Dostosować nazwę bazy danych bazaPomiarów do nazwy własnej bazy!
            //polaczenie z bazą
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            // Tworzy data adapter
            SqlDataAdapter a = new SqlDataAdapter("DELETE FROM Pomiary", con);
            // Uzywa DataAdapter do wypelnienia DataTable
            DataTable t = new DataTable();
            a.Fill(t);//wypelnienie danymi
            // wyswietlenie danych
            dataGridView1.DataSource = t;
            //zwolnienienie danych
            a.Dispose();
            t.Dispose();
            //zamkniecie polaczenia
            con.Close();
        }

        private void SORT_BUTTON_Click(object sender, EventArgs e)
        {
            string up_edge = UP_EDGE.Text;
            string down_edge = DOWN_EDGE.Text;
            //ciag polaczenia do bazy i tabeli
            string strcon = "Data Source=(local)\\sqlexpress;Initial Catalog=SkladPomiarow; Integrated Security=True";
            //Dostosować nazwę bazy danych bazaPomiarów do nazwy własnej bazy!
            //polaczenie z bazą
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            // Tworzy data adapter
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Pomiary WHERE DataPomiaru < = '" + up_edge + "' AND DataPomiaru > = '" + down_edge + "';", con);
            // Uzywa DataAdapter do wypelnienia DataTable
            DataTable t = new DataTable();
            a.Fill(t);//wypelnienie danymi
            // wyswietlenie danych
            dataGridView1.DataSource = t;
            //zwolnienienie danych
            a.Dispose();
            t.Dispose();
            //zamkniecie polaczenia
            con.Close();
        }

        private void RETURN_MAIN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
