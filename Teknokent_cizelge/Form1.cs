using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;
using DataTable = System.Data.DataTable;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

using Microsoft.Data.Sqlite;


namespace Teknokent_cizelge
{
    public partial class Form1 : Form
    {
        SqliteConnection baglanti = new SqliteConnection(@"Data Source=Datetime.db");

        public void listele()
        {
            baglanti.Open();
            SqliteCommand cek = new SqliteCommand();
            cek.Connection = baglanti;
            cek.CommandText = "Select Tc,Tarih, Baslangic_Saati, Bitis_Saati from olustur";
            using (SqliteDataReader veri = cek.ExecuteReader())
            {
                System.Data.DataTable dt = new DataTable();
                dt.Load(veri);
                veri.Close();
                baglanti.Close();
                dataGridView1.DataSource = dt;
            }
        }
        public void Olustur(int i ,string ay, string yil)
        {
            
            baglanti.Open();
            string ekle = "insert into olustur(id,Tc,Tarih,Baslangic_Saati,Bitis_Saati) values (@id,@Tc,@Tarih,@Baslangic_Saati,@Bitis_Saati)";
            SqliteCommand gonder = new SqliteCommand(ekle, baglanti);
           gonder.Parameters.AddWithValue("@id", i);
            gonder.Parameters.AddWithValue("@Tc", tc_girisbox.Text);
            gonder.Parameters.AddWithValue("@Tarih", i + "." + ay + "." + yil);
            gonder.Parameters.AddWithValue("@Baslangic_Saati", "08:00" );
            gonder.Parameters.AddWithValue("@Bitis_Saati","17:00" );

            gonder.ExecuteNonQuery();  //?????????
            baglanti.Dispose();
            gonder.Dispose();
            //MessageBox.Show("Aktarım Tamamlandı");
        }
        public void Sil(int id)
        {
            baglanti.Open();
            string sil = "delete from olustur where id='" + id + "'";
            SqliteCommand temizle = new SqliteCommand(sil, baglanti);
            temizle.ExecuteNonQuery();
            baglanti.Close();
            listele();

        }
        public static int Gunbul (int ay, int yil)
        {
            switch (ay)
            {
                case 1:
                    return 31;
                    break;
                case 2:
                    if (yil % 4 == 0)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                        break;
                    }
     
                case 3:
                    return 31;
                    break;
                case 4:
                    return 30;
                    break;
                case 5:
                    return 31;
                    break;
                case 6:
                    return 30;
                    break;
                case 7:
                    return 31;
                    break;
                case 8:
                    return 31;
                    break;
                case 9:
                    return 30;
                    break;
                case 10:
                    return 31;
                    break;
                case 11:
                    return 30;
                    break;
                case 12:
                    return 31;
                    break;
                default:
                    return 1;

            }
        }
        public Form1()
        {
            InitializeComponent();


           
            
            baglanti.Open();

            string sql = "select  *from aylar";

            SqliteCommand komut = new SqliteCommand(sql, baglanti);
            SqliteDataReader read = komut.ExecuteReader();

            comboBox1.Items.Add("Aylar");
            while (read.Read())
            {
                comboBox1.Items.Add(read["aylar_ad"]);
            }

            baglanti.Close();

            baglanti.Open();

            string sql1 = "select  *from yillar";

            SqliteCommand komut2 = new SqliteCommand(sql1, baglanti);
            SqliteDataReader read2 = komut2.ExecuteReader();

            while (read2.Read())
            {
                comboBox2.Items.Add(read2["yil_ad"]);
            }

            baglanti.Close();

          
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cizelge_button_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Ay ve Yıl Seçiniz");
            }
            else
            { 
                //İşlemler
                listBox1.Items.Clear();

                try
                {
                    for (int k = 1; k <= 31; k++)
                    {
                        Sil(k);
                    }
                }
                catch
                {
                    Console.WriteLine("Hata: ");
                }


                int a = comboBox1.SelectedIndex;
                int b = Convert.ToInt32(comboBox2.SelectedItem);
                
                //DateTime Ay = DateTime.Now.AddMonths(a);  //Ay Ekleme
                //DateTime Yil = DateTime.Now.AddYears(b);  //Yıl Ekleme
                string ay = Convert.ToString(comboBox1.SelectedIndex);


               

                for (int i = 1; i <= Gunbul(a, b); i++)
                {

                    DateTime dt = new DateTime(b, a, i);
                    int kacinciGun = (int)dt.DayOfWeek;

                    if (kacinciGun == 6 || kacinciGun == 0)   // haftasonu
                    {
                        if (kacinciGun == 0)
                        {
                            listBox1.Items.Add(i + " / " + comboBox1.SelectedItem + " / " + b);
                            //  Olustur(i, ay, b.ToString(), "PAZAR", "Hafta Sonu");
                        }
                        else
                        {
                            listBox1.Items.Add(i + " / " + comboBox1.SelectedItem + " / " + b);
                            //Olustur(i, ay, b.ToString(), "CUMARTESİ", "Hafta Sonu");
                        }

                    }

                    else
                    {
                        switch (kacinciGun)
                        {
                            case 1:
                                //listBox1.Items.Add(tc_girisbox.Text + i+ " / " + comboBox1.SelectedItem + " / " + b);
                                Olustur(i, ay, b.ToString());
                                break;
                            case 2:
                                //listBox1.Items.Add(tc_girisbox.Text + i + " / " + comboBox1.SelectedItem + " / " + b);
                                Olustur(i, ay, b.ToString());
                                break;
                            case 3:
                                //listBox1.Items.Add(tc_girisbox.Text + i + " / " + comboBox1.SelectedItem + " / " + b);
                                Olustur(i, ay, b.ToString());
                                break;
                            case 4:
                                //listBox1.Items.Add(tc_girisbox.Text + i + " / " + comboBox1.SelectedItem + " / " + b);
                                Olustur(i, ay, b.ToString());
                                break;
                            case 5:
                                //listBox1.Items.Add(tc_girisbox.Text + i + " / " + comboBox1.SelectedItem + " / " + b);
                                Olustur(i, ay, b.ToString());
                                break;
                        }
                    }
                }

                listele();

                Excel.Application app = new Excel.Application();
                // app.Visible = true;
                Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
                object misValue = System.Reflection.Missing.Value;
                Worksheet sayfa = (Worksheet)kitap.Sheets[1];

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    Range alan = (Range)sayfa.Cells[1, 1];
                    alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                        alan2.Cells[2, 1] = dataGridView1[i, j].Value;
                    }
                }
                
                string fileName = String.Format((@"{0}\" + tc_girisbox.Text + "_" + (a) + "_" + b + ".xls"), System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase));

                kitap.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                kitap.Close(true, misValue, misValue);
                app.Quit();

                MessageBox.Show("Çizelge kaydedildi");
            }
           

          
        }
    }
}

