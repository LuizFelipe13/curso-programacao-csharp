using ContatosDesktop.Classes;
using SQLite;
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

namespace ContatosDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ReadDatabase();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NovaJaneladeContato novaJaneladeContato = new NovaJaneladeContato();
            novaJaneladeContato.ShowDialog();

            ReadDatabase();
        }
        void ReadDatabase()
        {
            List<Contato> contatos;
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contato>();
                contatos = conn.Table<Contato>().ToList();

            }
            if(contatos != null)
            {
                // foreach(var c in contatos)
                // {
                //     contactsListView.Items.Add(new ListViewItem()
                //     {
                //         Content = c
                //    });
                //}
                contactsListView.ItemsSource = contatos;
            }
        }
    }
}
