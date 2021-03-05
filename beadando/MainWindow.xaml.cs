using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace beadando
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Számlákat tároló példányok
        /// </summary>
        /// Számla 1
        Szamla szamla1 = new Szamla(1, "Lajos", 2500);
        //Számla 2 
        Szamla szamla2 = new Szamla(2, "Kolompár", 0);

        public MainWindow()
        {
            InitializeComponent();
            szamla1_tulaj.Text = szamla1.tulaj_nev;
            szamla1_egyenleg.Text = Convert.ToString(szamla1.egyenleg);
            szamla2_tulaj.Text = szamla2.tulaj_nev;
            szamla2_egyenleg.Text = Convert.ToString(szamla2.egyenleg);
        }
        /// <summary>
        /// A számal 1-ről utal a Számla 2-re
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void utal_1_Click(object sender, RoutedEventArgs e)
        {
            if (Szamla1_input.Text != "")
            {
                try
                {
                    int osszeg = Convert.ToInt32(Szamla1_input.Text);
                    bool eredmeny = szamla1.Utalas(osszeg, szamla2);
                    if (eredmeny)
                    {
                        MessageBox.Show("Sikeres utalás!");
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen utalás!");
                    }
                    szamla1_egyenleg.Text = Convert.ToString(szamla1.egyenleg);
                    szamla2_egyenleg.Text = Convert.ToString(szamla2.egyenleg);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Nem megfelelő karaktereket tartalmaz az összeg!");
                }
            }
            else
            {
                MessageBox.Show("Kérem adjon meg valamit");
            }
            
        }
        /// <summary>
        /// Az Számla 1-re tölt fel összeget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void feltolt_1_Click(object sender, RoutedEventArgs e)
        {
            if (Szamla1_input.Text != "")
            {
                try
                {
                    int osszeg = Convert.ToInt32(Szamla1_input.Text);
                    szamla1.Felrak(osszeg);
                    szamla1_egyenleg.Text = Convert.ToString(szamla1.egyenleg);
                    MessageBox.Show("Sikeres utalás!");
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Nem megfelelő karaktereket tartalmaz az összeg!");
                }
            }
            else
            {
                MessageBox.Show("Kérem adjon meg valamit");
            }
            
        }
        /// <summary>
        /// Kivesz egy összeget a Számla 1-ről
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kiv_1_Click(object sender, RoutedEventArgs e)
        {
            if (Szamla1_input.Text != "")
            {
                try
                {
                    int osszeg = Convert.ToInt32(Szamla1_input.Text);
                    szamla1.Levon(osszeg);
                    szamla1_egyenleg.Text = Convert.ToString(szamla1.egyenleg);
                    MessageBox.Show("Sikeres utalás!");
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Nem megfelelő karaktereket tartalmaz az összeg!");
                }
            }
            else
            {
                MessageBox.Show("Kérem adjon meg valamit");
            }
            
        }
        /// <summary>
        /// Megváltoztat ja a Számla 1 tulajdonos nevét
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valt_1_Click(object sender, RoutedEventArgs e)
        {
            if (Szamla1_input.Text != "")
            {
                szamla1.Valtas(Szamla1_input.Text);
                szamla1_tulaj.Text = szamla1.tulaj_nev;
            }
            else {
                MessageBox.Show("Kérem adjon meg valamit");
            }
        }

        /// <summary>
        /// Az Számla 2-re tölt fel összeget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void feltolt_2_Click(object sender, RoutedEventArgs e)
        {
            if (Szamla1_input.Text != "")
            {
                try
                {
                    int osszeg = Convert.ToInt32(Szamla2_input.Text);
                    szamla2.Felrak(osszeg);
                    szamla2_egyenleg.Text = Convert.ToString(szamla2.egyenleg);
                    MessageBox.Show("Sikeres utalás!");
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Nem megfelelő karaktereket tartalmaz az összeg!");
                }
            }
            else
            {
                MessageBox.Show("Kérem adjon meg valamit");
            }
            
        }
        /// <summary>
        /// A számal 2-ről utal a Számla 1-re
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void utal_2_Click(object sender, RoutedEventArgs e)
        {
            if (Szamla1_input.Text != "")
            {
                try
                {
                    int osszeg = Convert.ToInt32(Szamla2_input.Text);
                    bool eredmeny = szamla2.Utalas(osszeg, szamla1);
                    if (eredmeny)
                    {
                        MessageBox.Show("Sikeres utalás!");
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen utalás!");
                    }
                    szamla1_egyenleg.Text = Convert.ToString(szamla1.egyenleg);
                    szamla2_egyenleg.Text = Convert.ToString(szamla2.egyenleg);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Nem megfelelő karaktereket tartalmaz az összeg!");
                }
            }
            else
            {
                MessageBox.Show("Kérem adjon meg valamit");
            }
        }

        /// <summary>
        /// Kivesz egy összeget a Számla 2-ről
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kiv_2_Click(object sender, RoutedEventArgs e)
        {
            if (Szamla1_input.Text != "")
            {
                try
                {
                    int osszeg = Convert.ToInt32(Szamla2_input.Text);
                    szamla2.Levon(osszeg);
                    szamla2_egyenleg.Text = Convert.ToString(szamla2.egyenleg);
                    MessageBox.Show("Sikeres utalás!");
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Nem megfelelő karaktereket tartalmaz az összeg!");
                }
            }
            else
            {
                MessageBox.Show("Kérem adjon meg valamit");
            }
        }
        /// <summary>
        /// Megváltoztat ja a Számla 2 tulajdonos nevét
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valt_2_Click(object sender, RoutedEventArgs e)
        {
            if (Szamla1_input.Text != "")
            {
                szamla2.Valtas(Szamla2_input.Text);
                szamla2_tulaj.Text = szamla2.tulaj_nev;
            }
            else
            {
                MessageBox.Show("Kérem adjon meg valamit");
            }
        }
    }
}
