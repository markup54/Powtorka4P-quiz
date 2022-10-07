using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Powtorka4P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Pytanie> pytania;
        int nrPytania;
        int wybranaOdp = 0;
        RadioButton wybranyRadioBtn;
        
        public MainWindow()
        {
            InitializeComponent();

            // pytanie 1
            nrPytania = 0;
            pytania = przygotujPytania();
            wypelnij();
        }

        private ObservableCollection<Pytanie> przygotujPytania()
        {
            //string pytania
            ObservableCollection<Pytanie> pytania = new ObservableCollection<Pytanie>();
            List<string> odp = new List<string>();
            
            // pytanie 1
            odp.Add("a");
            odp.Add("b");
            odp.Add("c");
            pytania.Add(new Pytanie(0, "Pytanie 1", odp, 0));

            // pytanie 2
            odp.Add("a2");
            odp.Add("b2");
            odp.Add("c2");
            pytania.Add(new Pytanie(1, "Pytanie 2", odp, 1));

            // pytanie 3
            odp.Add("a3");
            odp.Add("b3");
            odp.Add("c3");
            pytania.Add(new Pytanie(2, "Pytanie 3", odp, 2));

            // todo: zmien nr pytania na pytania[]
            return pytania;
        }

        private void wypelnij()
        {
            tresc.Text = pytania[nrPytania].trescPytania;
            odpA.Content = pytania[nrPytania].odpowiedzi[0];
            odpB.Content = pytania[nrPytania].odpowiedzi[1];
            odpC.Content = pytania[nrPytania].odpowiedzi[2];
        }

        private bool sprawdzOdpowiedz()
        {
            bool czyDobraOdp = false;
            if (wybranyRadioBtn.Name == "odpA")
                wybranaOdp = 0;
            else if (wybranyRadioBtn.Name == "odpB")
                wybranaOdp = 1;
            else if (wybranyRadioBtn.Name == "odpC")
                wybranaOdp = 2;
            if (wybranaOdp == pytania[nrPytania].odpowiedzOK)
                return true;
            else
                return false;
        }

        private void wybrany_Checked(object sender, RoutedEventArgs e)
        {
            wybranyRadioBtn = sender as RadioButton;
        }

        private void nastepnePytanie()
        {
            if(nrPytania < pytania.Count -1)
            {
                nrPytania++;
                wypelnij();
            }
            else
            {
                nrPytania = 0;
                wypelnij();
            }
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            bool odpowiedz = sprawdzOdpowiedz();
            if (odpowiedz)
            {
                MessageBox.Show("Dobra odpowiedź");
                nastepnePytanie();
            }
            else
                MessageBox.Show("Zła odpowiedź");
        }
    }
}
