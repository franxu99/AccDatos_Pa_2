using Org.BouncyCastle.Utilities;
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

namespace AccDatos_Pa_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int res = -99;
            AccesoDatos ad = new AccesoDatos();
            res = ad.AltaDePelicula(tb_title.Text,
                                    tb_description.Text,
                                    int.Parse(tb_release_year.Text),
                                    int.Parse(tb_language_id.Text),
                                    int.Parse(tb_original_lenguage_id.Text),
                                    int.Parse(tb_rental_duration.Text),
                                    double.Parse(tb_rental_rate.Text),
                                    int.Parse(tb_length.Text),
                                    double.Parse(tb_replacement_cost.Text),
                                    tb_rating.Text,
                                    tb_special_features.Text);
            MessageBox.Show(res.ToString());
            if(res == 0)
            {
                MessageBox.Show("Pelicula ingresada con exito");
            }
        }
    }
}