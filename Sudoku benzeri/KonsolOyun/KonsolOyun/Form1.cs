using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonsolOyun
{
    public partial class Form1 : Form
    {
        Game game = new Game();


        public int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
        public int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
        public int[] array3 = new int[5] { 1, 2, 3, 4, 5 };
        public int[] array4 = new int[5] { 1, 2, 3, 4, 5 };
        public int[] array5 = new int[5] { 1, 2, 3, 4, 5 };

        int[] satir1 = new int[5];
        int[] satir2 = new int[5];
        int[] satir3 = new int[5];
        int[] satir4 = new int[5];
        int[] satir5 = new int[5];


        //yapılan hamle sayısının tutulacagı değişken
        int gamesplayed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            satir1 = game.Karistir(array1);
            satir2 = game.Karistir(array2);
            satir3 = game.Karistir(array3);
            satir4 = game.Karistir(array4);
            satir5 = game.Karistir(array5);

            hintleriTemizle();
            kutulariDoldur();
            kutulariGizleHintver();
            kutulariBeyazlat();
            
              //  int sayac = 0;
             //   sayac++;
             //   System.Threading.Thread.Sleep(10);
             //   label3.Text = Convert.ToString(sayac);
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(null, EventArgs.Empty);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            kutulariDoldur();
            kutulariBeyazlat();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            gamesplayed++;
            label2.Text = Convert.ToString(gamesplayed);
            //1.satır kontrolleri
            if (t00.Text != Convert.ToString(satir1[0]))
            {
                t00.BackColor = Color.Red;

            }
            else
            {
                t00.BackColor = Color.White;
            }
            if (t01.Text != Convert.ToString(satir1[1]))
            {
                t01.BackColor = Color.Red;

            }
            else
            {
                t01.BackColor = Color.White;
            }

            if (t02.Text != Convert.ToString(satir1[2]))
            {
                t02.BackColor = Color.Red;

            }
            else
            {
                t02.BackColor = Color.White;
            }
            if (t03.Text != Convert.ToString(satir1[3]))
            {
                t03.BackColor = Color.Red;

            }
            else
            {
                t03.BackColor = Color.White;
            }

            if (t04.Text != Convert.ToString(satir1[4]))
            {
                t04.BackColor = Color.Red;

            }
            else
            {
                t04.BackColor = Color.White;
            }
            //2.satır kontrolü
            if (t10.Text != Convert.ToString(satir2[0]))
            {
                t10.BackColor = Color.Red;

            }
            else
            {
                t10.BackColor = Color.White;
            }
            if (t11.Text != Convert.ToString(satir2[1]))
            {
                t11.BackColor = Color.Red;

            }
            else
            {
                t11.BackColor = Color.White;
            }

            if (t12.Text != Convert.ToString(satir2[2]))
            {
                t12.BackColor = Color.Red;

            }
            else
            {
                t12.BackColor = Color.White;
            }
            if (t13.Text != Convert.ToString(satir2[3]))
            {
                t13.BackColor = Color.Red;

            }
            else
            {
                t13.BackColor = Color.White;
            }

            if (t14.Text != Convert.ToString(satir2[4]))
            {
                t14.BackColor = Color.Red;

            }
            else
            {
                t14.BackColor = Color.White;
            }

            //3.satır kontrolü
            if (t20.Text != Convert.ToString(satir3[0]))
            {
                t20.BackColor = Color.Red;

            }
            else
            {
                t20.BackColor = Color.White;
            }
            if (t21.Text != Convert.ToString(satir3[1]))
            {
                t21.BackColor = Color.Red;

            }
            else
            {
                t21.BackColor = Color.White;
            }

            if (t22.Text != Convert.ToString(satir3[2]))
            {
                t22.BackColor = Color.Red;

            }
            else
            {
                t22.BackColor = Color.White;
            }
            if (t23.Text != Convert.ToString(satir3[3]))
            {
                t23.BackColor = Color.Red;

            }
            else
            {
                t23.BackColor = Color.White;
            }

            if (t24.Text != Convert.ToString(satir3[4]))
            {
                t24.BackColor = Color.Red;

            }
            else
            {
                t24.BackColor = Color.White;
            }

            //4.satır kontrolü
            if (t30.Text != Convert.ToString(satir4[0]))
            {
                t30.BackColor = Color.Red;

            }
            else
            {
                t30.BackColor = Color.White;
            }
            if (t31.Text != Convert.ToString(satir4[1]))
            {
                t31.BackColor = Color.Red;

            }
            else
            {
                t31.BackColor = Color.White;
            }

            if (t32.Text != Convert.ToString(satir4[2]))
            {
                t32.BackColor = Color.Red;

            }
            else
            {
                t32.BackColor = Color.White;
            }
            if (t33.Text != Convert.ToString(satir4[3]))
            {
                t33.BackColor = Color.Red;

            }
            else
            {
                t33.BackColor = Color.White;
            }

            if (t34.Text != Convert.ToString(satir4[4]))
            {
                t34.BackColor = Color.Red;

            }
            else
            {
                t34.BackColor = Color.White;
            }

            //5.satır kontrolü
            if (t40.Text != Convert.ToString(satir5[0]))
            {
                t40.BackColor = Color.Red;

            }
            else
            {
                t40.BackColor = Color.White;
            }
            if (t41.Text != Convert.ToString(satir5[1]))
            {
                t41.BackColor = Color.Red;

            }
            else
            {
                t41.BackColor = Color.White;
            }

            if (t42.Text != Convert.ToString(satir5[2]))
            {
                t42.BackColor = Color.Red;

            }
            else
            {
                t42.BackColor = Color.White;
            }
            if (t43.Text != Convert.ToString(satir5[3]))
            {
                t43.BackColor = Color.Red;

            }
            else
            {
                t43.BackColor = Color.White;
            }

            if (t44.Text != Convert.ToString(satir5[4]))
            {
                t44.BackColor = Color.Red;

            }
            else
            {
                t44.BackColor = Color.White;
            }

        }
        private void hintleriTemizle()
        {
            
            label0001.Text = "";
            label0102.Text = "";
            label0203.Text = "";
            label0304.Text = "";

            label0010.Text = "";
            label0111.Text = "";
            label0212.Text = "";
            label0313.Text = "";
            label0414.Text = "";

            label1011.Text = "";
            label1112.Text = "";
            label1213.Text = "";
            label1314.Text = "";

            label1020.Text = "";
            label1121.Text = "";
            label1222.Text = "";
            label1323.Text = "";
            label1424.Text = "";

            label2021.Text = "";
            label2122.Text = "";
            label2223.Text = "";
            label2324.Text = "";

            label2030.Text = "";
            label2131.Text = "";
            label2232.Text = "";
            label2333.Text = "";
            label2434.Text = "";

            label3031.Text = "";
            label3132.Text = "";
            label3233.Text = "";
            label3334.Text = "";

            label3040.Text = "";
            label3141.Text = "";
            label3242.Text = "";
            label3343.Text = "";
            label3444.Text = "";

            label4041.Text = "";
            label4142.Text = "";
            label4243.Text = "";
            label4344.Text = "";
            
        }

        private void kutulariBeyazlat()
        {
            //tüm kutuları beyaz renk yapıyoruz kırmızı yaptıklarımız yeni oyunda gözükmesin
            t00.BackColor = Color.White;
            t01.BackColor = Color.White;
            t02.BackColor = Color.White;
            t03.BackColor = Color.White;
            t04.BackColor = Color.White;

            t10.BackColor = Color.White;
            t11.BackColor = Color.White;
            t12.BackColor = Color.White;
            t13.BackColor = Color.White;
            t14.BackColor = Color.White;

            t20.BackColor = Color.White;
            t21.BackColor = Color.White;
            t22.BackColor = Color.White;
            t23.BackColor = Color.White;
            t24.BackColor = Color.White;

            t30.BackColor = Color.White;
            t31.BackColor = Color.White;
            t32.BackColor = Color.White;
            t33.BackColor = Color.White;
            t34.BackColor = Color.White;

            t40.BackColor = Color.White;
            t41.BackColor = Color.White;
            t42.BackColor = Color.White;
            t43.BackColor = Color.White;
            t44.BackColor = Color.White;
        }

        private void kutulariGizleHintver()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    var random = new Random();
                    int rnd1 = random.Next(0, 5);
                    int rnd2 = random.Next(0, 5);

                    string boxtohide = "t" + Convert.ToString(rnd1) + Convert.ToString(rnd2);

                    if (boxtohide == "t00")
                    {
                        t00.Text = "";
                        if (satir1[0] < satir1[1]) { label0001.Text = "<"; }
                        if (satir1[0] > satir1[1]) { label0001.Text = ">"; }
                        if (satir1[0] < satir2[0]) { label0010.Text = "^"; }
                        if (satir1[0] > satir2[0]) { label0010.Text = "v"; }
                    }
                    if (boxtohide == "t01")
                    {
                        t01.Text = "";
                        if (satir1[0] < satir1[1]) { label0001.Text = "<"; }
                        if (satir1[0] > satir1[1]) { label0001.Text = ">"; }

                        if (satir1[1] < satir1[1]) { label0102.Text = "<"; }
                        if (satir1[1] > satir1[2]) { label0102.Text = ">"; }

                        if (satir1[1] < satir2[1]) { label0111.Text = "^"; }
                        if (satir1[1] > satir2[1]) { label0111.Text = "v"; }
                    }
                    if (boxtohide == "t02")
                    {
                        t02.Text = "";
                        if (satir1[1] < satir1[2]) { label0102.Text = "<"; }
                        if (satir1[1] > satir1[2]) { label0102.Text = ">"; }

                        if (satir1[2] < satir1[3]) { label0203.Text = "<"; }
                        if (satir1[2] > satir1[3]) { label0203.Text = ">"; }

                        if (satir1[2] < satir2[2]) { label0111.Text = "^"; }
                        if (satir1[2] > satir2[2]) { label0111.Text = "v"; }
                    }
                    if (boxtohide == "t03")
                    {
                        t03.Text = "";
                        if (satir1[2] < satir1[3]) { label0203.Text = "<"; }
                        if (satir1[1] > satir1[2]) { label0203.Text = ">"; }

                        if (satir1[3] < satir1[4]) { label0304.Text = "<"; }
                        if (satir1[3] > satir1[4]) { label0304.Text = ">"; }

                        if (satir1[3] < satir2[3]) { label0313.Text = "^"; }
                        if (satir1[3] > satir2[3]) { label0313.Text = "v"; }
                    }
                    if (boxtohide == "t04")
                    {
                        t04.Text = "";
                        if (satir1[3] < satir1[4]) { label0304.Text = "<"; }
                        if (satir1[3] > satir1[4]) { label0304.Text = ">"; }

                     

                        if (satir1[4] < satir2[4]) { label0414.Text = "^"; }
                        if (satir1[4] > satir2[4]) { label0414.Text = "v"; }
                    }
                    if (boxtohide == "t10")
                    {
                        t10.Text = "";
                        if (satir2[0] < satir2[1]) { label1011.Text = "<"; }
                        if (satir2[0] > satir2[1]) { label1011.Text = ">"; }


                        if (satir2[0] < satir3[0]) { label1020.Text = "^"; }
                        if (satir2[0] > satir3[0]) { label1020.Text = "v"; }

                    }
                    if (boxtohide == "t11")
                    {
                        t11.Text = "";
                        if (satir2[0] < satir2[1]) { label1011.Text = "<"; }
                        if (satir2[0] > satir2[1]) { label1011.Text = ">"; }

                        if (satir2[1] < satir2[2]) { label1112.Text = "<"; }
                        if (satir2[1] > satir2[2]) { label1112.Text = ">"; }

                        if (satir2[1] < satir3[1]) { label1121.Text = "^"; }
                        if (satir2[1] > satir3[1]) { label1121.Text = "v"; }
                    }
                    if (boxtohide == "t12")
                    {
                        t12.Text = "";
                        if (satir2[1] < satir2[2]) { label1112.Text = "<"; }
                        if (satir2[1] > satir2[2]) { label1112.Text = ">"; }

                        if (satir2[2] < satir2[3]) { label1213.Text = "<"; }
                        if (satir2[2] > satir2[3]) { label1213.Text = ">"; }

                        if (satir2[2] < satir3[2]) { label1222.Text = "^"; }
                        if (satir2[2] > satir3[2]) { label1222.Text = "v"; }
                    }
                    if (boxtohide == "t13")
                    {
                        t13.Text = "";
                        if (satir2[2] < satir2[3]) { label1213.Text = "<"; }
                        if (satir2[2] > satir2[3]) { label1213.Text = ">"; }

                        if (satir2[3] < satir2[4]) { label1314.Text = "<"; }
                        if (satir2[3] > satir2[4]) { label1314.Text = ">"; }

                        if (satir2[3] < satir3[3]) { label1323.Text = "^"; }
                        if (satir2[3] > satir3[3]) { label1323.Text = "v"; }
                    }
                    if (boxtohide == "t14")
                    {
                        t14.Text = "";
                        if (satir2[3] < satir2[4]) { label1314.Text = "<"; }
                        if (satir2[3] > satir2[4]) { label1314.Text = ">"; }
                                               
                        if (satir2[4] < satir3[4]) { label1424.Text = "^"; }
                        if (satir2[4] > satir3[4]) { label1424.Text = "v"; }
                    }

                    if (boxtohide == "t20")
                    {
                        t20.Text = "";
                        if (satir3[0] < satir2[0]) { label1020.Text = "v"; }
                        if (satir3[0] > satir2[0]) { label1020.Text = "^"; }

                        if (satir3[0] < satir3[1]) { label2021.Text = "<"; }
                        if (satir3[0] > satir3[1]) { label2021.Text = ">"; }

                        if (satir3[0] < satir4[0]) { label2030.Text = "^"; }
                        if (satir3[0] > satir2[0]) { label2030.Text = "v"; }
                    }
                    if (boxtohide == "t21")
                    {
                        t21.Text = "";
                        if (satir3[0] < satir3[1]) { label2021.Text = "<"; }
                        if (satir3[0] > satir3[1]) { label2021.Text = ">"; }

                        if (satir3[1] < satir3[2]) { label2122.Text = "<"; }
                        if (satir3[1] > satir3[2]) { label2122.Text = ">"; }

                        if (satir3[1] < satir4[1]) { label2131.Text = "^"; }
                        if (satir3[1] > satir4[1]) { label2131.Text = "v"; }
                    }
                    if (boxtohide == "t22")
                    {
                        t22.Text = "";

                        if (satir3[1] < satir3[2]) { label2122.Text = "<"; }
                        if (satir3[1] > satir3[2]) { label2122.Text = ">"; }

                        if (satir3[2] < satir3[3]) { label2223.Text = "<"; }
                        if (satir3[2] > satir3[3]) { label2223.Text = ">"; }

                        if (satir3[2] < satir4[2]) { label2232.Text = "^"; }
                        if (satir3[2] > satir4[2]) { label2232.Text = "v"; }
                    }
                    if (boxtohide == "t23")
                    {
                        t23.Text = "";
                        if (satir3[2] < satir3[3]) { label2223.Text = "<"; }
                        if (satir3[2] > satir3[3]) { label2223.Text = ">"; }

                        if (satir3[3] < satir3[4]) { label2324.Text = "<"; }
                        if (satir3[3] > satir3[4]) { label2324.Text = ">"; }

                        if (satir3[3] < satir4[3]) { label2333.Text = "^"; }
                        if (satir3[3] > satir4[3]) { label2333.Text = "v"; }
                    }
                    if (boxtohide == "t24")
                    {
                        t24.Text = "";
                        if (satir3[3] < satir3[4]) { label2324.Text = "<"; }
                        if (satir3[3] > satir3[4]) { label2324.Text = ">"; }
                                              

                        if (satir3[4] < satir4[4]) { label2434.Text = "^"; }
                        if (satir3[4] > satir4[4]) { label2434.Text = "v"; }
                    }

                    if (boxtohide == "t30")
                    {
                        t30.Text = "";
                        if (satir4[0] < satir4[1]) { label3031.Text = "<"; }
                        if (satir4[0] > satir4[1]) { label3031.Text = ">"; }


                        if (satir4[0] < satir5[0]) { label3040.Text = "^"; }
                        if (satir4[0] > satir5[0]) { label3040.Text = "v"; }

                    }
                    if (boxtohide == "t31")
                    {
                        t31.Text = "";
                        if (satir4[0] < satir4[1]) { label3031.Text = "<"; }
                        if (satir4[0] > satir4[1]) { label3031.Text = ">"; }

                        if (satir4[1] < satir4[2]) { label3132.Text = "<"; }
                        if (satir4[1] > satir4[2]) { label3132.Text = ">"; }

                        if (satir4[1] < satir5[1]) { label3141.Text = "^"; }
                        if (satir4[1] > satir5[1]) { label3141.Text = "v"; }

                    }
                    if (boxtohide == "t32")
                    {
                        t32.Text = "";
                        if (satir4[1] < satir4[2]) { label3132.Text = "<"; }
                        if (satir4[1] > satir4[2]) { label3132.Text = ">"; }

                        if (satir4[2] < satir4[3]) { label3233.Text = "<"; }
                        if (satir4[2] > satir4[3]) { label3233.Text = ">"; }

                        if (satir4[2] < satir5[2]) { label3242.Text = "^"; }
                        if (satir4[2] > satir5[2]) { label3242.Text = "v"; }
                    }
                    if (boxtohide == "t33")
                    {
                        t33.Text = "";
                        if (satir4[2] < satir4[3]) { label3233.Text = "<"; }
                        if (satir4[2] > satir4[3]) { label3233.Text = ">"; }

                        if (satir4[3] < satir4[4]) { label3334.Text = "<"; }
                        if (satir4[3] > satir4[4]) { label3334.Text = ">"; }

                        if (satir4[3] < satir5[3]) { label3343.Text = "^"; }
                        if (satir4[3] > satir5[3]) { label3343.Text = "v"; }
                    }
                    if (boxtohide == "t34")
                    {
                        t34.Text = "";
                        if (satir4[3] < satir4[4]) { label3334.Text = "<"; }
                        if (satir4[3] > satir4[4]) { label3334.Text = ">"; }

                        if (satir4[4] < satir5[4]) { label3444.Text = "^"; }
                        if (satir4[4] > satir5[4]) { label3444.Text = "v"; }
                    }

                    if (boxtohide == "t40")
                    {
                        t40.Text = "";
                        if (satir5[0] < satir4[0]) { label3040.Text = "v"; }
                        if (satir5[0] > satir4[0]) { label3334.Text = "^"; }

                        if (satir5[0] < satir5[1]) { label4041.Text = "<"; }
                        if (satir5[0] > satir5[1]) { label4041.Text = ">"; }

                    }
                    if (boxtohide == "t41")
                    {
                        t41.Text = "";
                        if (satir5[0] < satir5[1]) { label4041.Text = "<"; }
                        if (satir5[0] > satir5[1]) { label4041.Text = ">"; }

                        if (satir5[1] < satir4[1]) { label4041.Text = "v"; }
                        if (satir5[1] > satir4[1]) { label4041.Text = "^"; }

                        if (satir5[1] < satir5[2]) { label4142.Text = "<"; }
                        if (satir5[1] > satir5[2]) { label4142.Text = ">"; }
                    }
                    if (boxtohide == "t42")
                    {
                        t42.Text = "";
                        if (satir5[1] < satir5[2]) { label4142.Text = "<"; }
                        if (satir5[1] > satir5[2]) { label4142.Text = ">"; }

                        if (satir5[2] < satir4[2]) { label3242.Text = "v"; }
                        if (satir5[2] > satir4[2]) { label3242.Text = "^"; }

                        if (satir5[2] < satir5[3]) { label4243.Text = "<"; }
                        if (satir5[2] > satir5[3]) { label4243.Text = ">"; }
                    }
                    if (boxtohide == "t43")
                    {
                        t43.Text = "";
                        if (satir5[2] < satir5[3]) { label4243.Text = "<"; }
                        if (satir5[2] > satir5[3]) { label4243.Text = ">"; }

                        if (satir5[3] < satir4[3]) { label3343.Text = "v"; }
                        if (satir5[3] > satir4[3]) { label3343.Text = "^"; }

                        if (satir5[3] < satir5[4]) { label4344.Text = "<"; }
                        if (satir5[3] > satir5[4]) { label4344.Text = ">"; }
                    }
                    if (boxtohide == "t44")
                    {
                        t44.Text = "";

                        if (satir5[3] < satir5[4]) { label4344.Text = "<"; }
                        if (satir5[3] > satir5[4]) { label4344.Text = ">"; }

                        if (satir5[4] < satir4[4]) { label3444.Text = "v"; }
                        if (satir5[4] > satir4[4]) { label3444.Text = "^"; }

                    }
                }



            }
        }
            public void kutulariDoldur()
            {
                t00.Text = Convert.ToString(satir1[0]);
                t01.Text = Convert.ToString(satir1[1]);
                t02.Text = Convert.ToString(satir1[2]);
                t03.Text = Convert.ToString(satir1[3]);
                t04.Text = Convert.ToString(satir1[4]);

                t10.Text = Convert.ToString(satir2[0]);
                t11.Text = Convert.ToString(satir2[1]);
                t12.Text = Convert.ToString(satir2[2]);
                t13.Text = Convert.ToString(satir2[3]);
                t14.Text = Convert.ToString(satir2[4]);

                t20.Text = Convert.ToString(satir3[0]);
                t21.Text = Convert.ToString(satir3[1]);
                t22.Text = Convert.ToString(satir3[2]);
                t23.Text = Convert.ToString(satir3[3]);
                t24.Text = Convert.ToString(satir3[4]);

                t30.Text = Convert.ToString(satir4[0]);
                t31.Text = Convert.ToString(satir4[1]);
                t32.Text = Convert.ToString(satir4[2]);
                t33.Text = Convert.ToString(satir4[3]);
                t34.Text = Convert.ToString(satir4[4]);

                t40.Text = Convert.ToString(satir5[0]);
                t41.Text = Convert.ToString(satir5[1]);
                t42.Text = Convert.ToString(satir5[2]);
                t43.Text = Convert.ToString(satir5[3]);
                t44.Text = Convert.ToString(satir5[4]);
            }

        

       

        
    }
    }

