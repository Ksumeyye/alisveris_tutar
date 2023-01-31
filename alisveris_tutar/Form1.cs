namespace alisveris_tutar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ksayi,kitap;
            double hesap, ibir, iiki, iuc;
            kitap = 10;
            ibir = 0.20;
            iiki = 0.40;
            iuc = 0.50;
            ksayi = Convert.ToInt16(textBox1.Text);
            if (ksayi <= 20)
            {
                hesap = ((kitap*ksayi) - (kitap * ibir*ksayi));
                textBox2.Text = (ksayi + " --> " + hesap + " TL ");
            }
            else if (ksayi >= 21 && ksayi <= 40)
            {
                hesap = ((kitap * ksayi) - (kitap*ksayi*iiki));
                textBox2.Text = (ksayi + " --> " + hesap + " TL ");
            }
            else
            {
                hesap = ((kitap*ksayi)-(kitap*ksayi*iuc));
                textBox2.Text = (ksayi + " --> " + hesap + " TL ");
            }
                        
        }
    }
}