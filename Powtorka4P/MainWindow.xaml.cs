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
        int nrPytania = 0;
        public MainWindow()
        {
            InitializeComponent();

            pytania = przygotujPytania();
            wypelnij(nrPytania);
        }

        private ObservableCollection<Pytanie> przygotujPytania()
        {
            //string pytania
            ObservableCollection<Pytanie> pytania = new ObservableCollection<Pytanie>();

            List<string> odp = new List<string>();
            odp.Add("a");
            odp.Add("b");
            odp.Add("c");
            pytania.Add(new Pytanie(1, "Pytanie 1", odp, 1));

            return pytania;
        }

        private void wypelnij(int n)
        {
            tresc.Text = pytania[n].trescPytania;
            odpA.Content = pytania[n].odpowiedzi[0];
            odpB.Content = pytania[n].odpowiedzi[1];
            odpC.Content = pytania[n].odpowiedzi[2];
        }

        private bool sprawdzOdpowiedz()
        {
            bool czyDobraOdp;
            
            return czyDobraOdp;
        }
    }
}
