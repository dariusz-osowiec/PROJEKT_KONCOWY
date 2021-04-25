using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Data.SqlClient;


namespace ProjektKoncowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PROCESSING SITEP = new PROCESSING();
            Thread SITE = null;
            SITE = new Thread(P1.WEB_Work);
            SITE.Start();
        }

        public Form2 otherForm2;
        static Mutex mut;
        static string setting_data1a, setting_data1b; //dla sim 1
        static string setting_data2a, setting_data2b; //dla sim 2
        static string setting_data3a, setting_data3b; //dla sim 3
        static string message_get_data_1 = "";
        static string message_get_data_2 = "";
        static string message_get_data_3 = "";
        

        

        class PROCESSING
        {
            public bool isStop = false;
            public bool isStop2 = false;
            public bool isStop3 = false;
            public bool isStopWeb = false;

            public void WEB_Work()
            {
                while (!isStopWeb)
                {
                    HttpListener listener = new HttpListener();
                    listener.Prefixes.Add("http://localhost:8080/realtime/");
                    listener.Start();
                    HttpListenerContext context = listener.GetContext();
                    HttpListenerRequest request = context.Request;
                    HttpListenerResponse response = context.Response;
                    string responseString = "<HTML><BODY>Aktualne pomiary</BR>" + DateTime.Now.ToString() + "</BR>" + message_get_data_1 + "</BR>" + message_get_data_2 + "</BR>" + message_get_data_3 + "</BODY></HTML>";
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                    response.ContentLength64 = buffer.Length;
                    System.IO.Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                    output.Close();
                    listener.Stop();
                }
            }

            public void SIM1_Work()
            {
                while (!isStop)
                {
                    try
                    {
                        mut.WaitOne();
                        string sql;
                        SqlCommand com;
                        /////////////////////////////////////////////
                        TcpClient client = new TcpClient();
                        client.Connect(IPAddress.Parse(setting_data1a), Convert.ToInt32(setting_data1b));
                        NetworkStream stream = client.GetStream();
                        BinaryWriter SWrite = new BinaryWriter(stream);
                        BinaryReader Sread = new BinaryReader(stream);
                        /////////////////////////////////////////////
                        string strcon = "Data Source=(local)\\sqlexpress;Initial Catalog=SkladPomiarow ;Integrated Security=True";//Dostosować nazwę bazy danych bazaPomiarów do nazwy własnej bazy!
                        SqlConnection con = new SqlConnection(strcon); //obiekt połączenia do bazy
                        con.Open(); //otwarcie polaczenia do bazy danych
                        ///////////////////////////////////////////////
                        //formatowanie ciagu polecenia sql do wykonania. Dodawanie danych do tabeli
                        SWrite.Write(Convert.ToByte(2));
                        int DataGetI = Sread.ReadInt16();
                        SWrite.Write(Convert.ToByte(1));
                        int DataGetU = Sread.ReadInt16();
                        sql = "insert into Pomiary(I, U, DataPomiaru, Symulator) values (" +
                            DataGetI + "," + //zapisana wartosc liczbowa (bez apostrofów)
                            DataGetU + ",'" + DateTime.Now.ToString() + "','SIM1');";//koniec polecenie sql (;)
                        com = new SqlCommand(sql, con);//obiekt command
                        com.ExecuteNonQuery(); //uruchomienie polecenie
                        message_get_data_1 = "Odebrano dane: I = " + DataGetI + " U = " + DataGetU + " z SIM1";
                        con.Close(); //zamykanie polaczenia
                        client.Close();
                        //Thread.Sleep(1000);
                    }
                    finally
                    {
                        mut.ReleaseMutex();//wylaczenie muteksu
                        Thread.Sleep(1000);
                    }
                }
            }
            public void SIM2_Work()
            {
                while (!isStop2)
                {
                    try
                    {
                        mut.WaitOne();
                        string sql;
                        SqlCommand com;
                        /////////////////////////////////////////////
                        TcpClient client = new TcpClient();
                        client.Connect(IPAddress.Parse(setting_data2a), Convert.ToInt32(setting_data2b));
                        NetworkStream stream = client.GetStream();
                        BinaryWriter SWrite = new BinaryWriter(stream);
                        BinaryReader Sread = new BinaryReader(stream);
                        /////////////////////////////////////////////
                        string strcon = "Data Source=(local)\\sqlexpress;Initial Catalog=SkladPomiarow ;Integrated Security=True";//Dostosować nazwę bazy danych bazaPomiarów do nazwy własnej bazy!
                        SqlConnection con = new SqlConnection(strcon); //obiekt połączenia do bazy
                        con.Open(); //otwarcie polaczenia do bazy danych
                        ///////////////////////////////////////////////
                        //formatowanie ciagu polecenia sql do wykonania. Dodawanie danych do tabeli                
                        SWrite.Write(Convert.ToByte(2));
                        int DataGetI = Sread.ReadInt16();
                        SWrite.Write(Convert.ToByte(1));
                        int DataGetU = Sread.ReadInt16();
                        sql = "insert into Pomiary(I, U, DataPomiaru, Symulator) values (" +
                            DataGetI + "," + //zapisana wartosc liczbowa (bez apostrofów)
                            DataGetU + ",'" + DateTime.Now.ToString() + "','SIM2');";//koniec polecenie sql (;)
                        com = new SqlCommand(sql, con);//obiekt command
                        com.ExecuteNonQuery(); //uruchomienie polecenie
                        message_get_data_2 = "Odebrano dane: I = " + DataGetI + " U = " + DataGetU + " z SIM2";
                        con.Close(); //zamykanie polaczenia
                        client.Close();
                        //Thread.Sleep(1000);
                    }
                    finally
                    {
                        mut.ReleaseMutex();//wylaczenie muteksu
                        Thread.Sleep(1000);
                    }
                }
            }
            public void SIM3_Work()
            {
                 while (!isStop3)
                 {
                    try
                    {
                        mut.WaitOne();
                        string sql;
                        SqlCommand com;
                        /////////////////////////////////////////////
                        TcpClient client = new TcpClient();
                        client.Connect(IPAddress.Parse(setting_data3a), Convert.ToInt32(setting_data3b));
                        NetworkStream stream = client.GetStream();
                        BinaryWriter SWrite = new BinaryWriter(stream);
                        BinaryReader Sread = new BinaryReader(stream);
                        /////////////////////////////////////////////
                        string strcon = "Data Source=(local)\\sqlexpress;Initial Catalog=SkladPomiarow ;Integrated Security=True";//Dostosować nazwę bazy danych bazaPomiarów do nazwy własnej bazy!
                        SqlConnection con = new SqlConnection(strcon); //obiekt połączenia do bazy
                        con.Open(); //otwarcie polaczenia do bazy danych
                        ///////////////////////////////////////////////
                        //formatowanie ciagu polecenia sql do wykonania. Dodawanie danych do tabeli
                        SWrite.Write(Convert.ToByte(2));
                        int DataGetI = Sread.ReadInt16();
                        SWrite.Write(Convert.ToByte(1));
                        int DataGetU = Sread.ReadInt16();
                        sql = "insert into Pomiary(I, U, DataPomiaru, Symulator) values (" +
                            DataGetI + "," + //zapisana wartosc liczbowa (bez apostrofów)
                            DataGetU + ",'" + DateTime.Now.ToString() + "','SIM3');";//koniec polecenie sql (;)
                        com = new SqlCommand(sql, con);//obiekt command
                        com.ExecuteNonQuery(); //uruchomienie polecenie
                        message_get_data_3 = "Odebrano dane: I = " + DataGetI + " U = " + DataGetU + " z SIM3";
                        con.Close(); //zamykanie polaczenia
                        client.Close();
                        //Thread.Sleep(1000);
                    }
                    finally
                    {
                        mut.ReleaseMutex();//wylaczenie muteksu
                        Thread.Sleep(1000);
                    }
                }
            }
        }


        PROCESSING P1 = new PROCESSING();
        Thread T1 = null;
        public void SIM1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            setting_data1a = IP_SIM1.Text;
            setting_data1b = PORT_SIM1.Text;        
            if (T1 != null)
            {
                P1.isStop = true;
                T1 = null;
                timer1.Enabled = false;
                CHECK.Items.Add("Zatrzymano wątek symulatora 1");
                
            }
            else
            {
                try
                { //najpierw sprawdzenie, czy muteks nie jest juz utworzony
                    mut = Mutex.OpenExisting("test");
                    //jesli nie ma bledu to juz byl utworzony przez drugi program
                    CHECK.Items.Add("SIM1 dołączył do Mutexu");
                }
                catch //nie ma muteksu.
                {
                    mut = new Mutex(false, "test");//nie bylo muteksu
                    CHECK.Items.Add("SIM1 utworzył Mutex");
                }
                P1.isStop = false;
                T1 = new Thread(P1.SIM1_Work);
                T1.Start();
                timer1.Enabled = true;
                CHECK.Items.Add("Uruchomiono wątek symulatora 1");
            }

        }

        PROCESSING P2 = new PROCESSING();
        Thread T2 = null;
        public void SIM2_Click(object sender, EventArgs e)
        {
            setting_data2a = IP_SIM2.Text;
            setting_data2b = PORT_SIM2.Text;
            if (T2 != null)
            {
                P2.isStop = true;
                T2 = null;
                timer2.Enabled = false;
                CHECK.Items.Add("Zatrzymano wątek symulatora 2");

            }
            else
            {
                try
                { //najpierw sprawdzenie, czy muteks nie jest juz utworzony
                    mut = Mutex.OpenExisting("test");
                    //jesli nie ma bledu to juz byl utworzony przez drugi program
                    CHECK.Items.Add("SIM2 dołączył do Mutexu");
                }
                catch //nie ma muteksu.
                {
                    mut = new Mutex(false, "test");//nie bylo muteksu
                    CHECK.Items.Add("SIM2 utworzył Mutex");
                    //Utworzono Mutex test
                }
                P2.isStop = false;
                T2 = new Thread(P2.SIM2_Work);
                T2.Start();
                timer2.Enabled = true;
                CHECK.Items.Add("Uruchomiono wątek symulatora 2");
            }
        }

        PROCESSING P3 = new PROCESSING();
        Thread T3 = null;
        private void SIM3_Click(object sender, EventArgs e)
        {
            setting_data3a = IP_SIM3.Text;
            setting_data3b = PORT_SIM3.Text;
            if (T3 != null)
            {
                P3.isStop = true;
                T3 = null;
                timer3.Enabled = false;
                CHECK.Items.Add("Zatrzymano wątek symulatora 3");
            }
            else
            {
                try
                { //najpierw sprawdzenie, czy muteks nie jest juz utworzony
                    mut = Mutex.OpenExisting("test");
                    CHECK.Items.Add("SIM3 dołączył do Mutexu");
                    //jesli nie ma bledu to juz byl utworzony przez drugi program
                    //"Dołączono do Mutexu test
                }
                catch //nie ma muteksu.
                {
                    mut = new Mutex(false, "test");//nie bylo muteksu
                    CHECK.Items.Add("SIM3 utworzył Mutex");
                    //Utworzono Mutex test
                }
                P3.isStop = false;
                T3 = new Thread(P3.SIM3_Work);
                T3.Start();
                timer3.Enabled = true;
                CHECK.Items.Add("Uruchomiono wątek symulatora 3");
            }
        }

        private void MEASURE_Click(object sender, EventArgs e)
        {
            Form2 window = new Form2();
            window.ShowDialog();
        }

        private void Close_Program_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CHECK.Items.Add(message_get_data_1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CHECK.Items.Add(message_get_data_2);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            CHECK.Items.Add(message_get_data_3);
        }
    }
}
