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

namespace Personalverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string Vorname;
        string Nachname;
        int PLZ;
        string Ort;
        string Abteilung;
        double Gehalt;
        private void BtnVorname_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(UniversalBox.Text))
            {
                MessageBox.Show("Bitte erst den Vornamen eingeben!");
            }
            else
            {
                Vorname = UniversalBox.Text;
                UniversalBox.Text = "";
            }
        }

        private void BtnNachname_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(UniversalBox.Text))
            {
                MessageBox.Show("Bitte erst den Nachnamen eingeben!");
            }
            else
            {
                Nachname = UniversalBox.Text;
                UniversalBox.Text = "";
            }
        }

        private void BtnPLZ_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(UniversalBox.Text))
            {
                MessageBox.Show("Bitte erst die PLZ eingeben!");
            }
            else
            {
                int plz2 = Convert.ToInt32(UniversalBox.Text);
                PLZ = plz2;
                UniversalBox.Text = "";
            }
        }

        private void BtnOrt_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(UniversalBox.Text))
            {
                MessageBox.Show("Bitte erst den Ort eingeben!");
            }
            else
            {
                Ort = UniversalBox.Text;
                UniversalBox.Text = "";
            }
        }

        private void BtnAbteilung_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(UniversalBox.Text))
            {
                MessageBox.Show("Bitte erst die Abteilung eingeben!");
            }
            else
            {
                Abteilung = UniversalBox.Text;
                UniversalBox.Text = "";
            }
        }

        private void BtnGehalt_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(UniversalBox.Text))
            {
                MessageBox.Show("Bitte erst das Gehalt eingeben!");
            }
            else
            {
                double gehalt2 = Convert.ToDouble(UniversalBox.Text);
                Gehalt = gehalt2;
                UniversalBox.Text = "";
            }
        }

        private void Btnoutput_Click(object sender, RoutedEventArgs e)
        {
            // This is where you would Output all values.
            UniversalBox.Text =  $"{Vorname} {Nachname} | {PLZ} {Ort} | {Abteilung} | {Gehalt}";
            ausgabeLabel.Content = $"{Vorname} {Nachname} | {PLZ} {Ort} | {Abteilung} | {Gehalt}";
        }
    }
}
