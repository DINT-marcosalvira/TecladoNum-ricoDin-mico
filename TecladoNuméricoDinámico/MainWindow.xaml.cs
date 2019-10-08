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

namespace TecladoNuméricoDinámico
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button boton; ;
            TextBlock tb;
            Viewbox vb;
            int contador = 1;
            for (int i = 2; i <= 4; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    //Variables
                    boton = new Button();
                    tb = new TextBlock();
                    vb = new Viewbox();
                    //Orden
                    GridTabla.Children.Add(boton);
                    boton.Content = vb;
                    vb.Child = tb;
                    //Propiedades
                    tb.Text = contador.ToString();
                    boton.Tag = contador;
                    Grid.SetColumn(boton, z);
                    Grid.SetRow(boton, i);
                    boton.Margin = new Thickness(3);
                    contador++;
                    boton.Click += Boton_Click;
                }
            }
            

        }
        

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;

            BloqueTexto.Text += but.Tag;
        }
    }
}
