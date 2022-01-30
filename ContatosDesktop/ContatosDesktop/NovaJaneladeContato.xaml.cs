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
using System.Windows.Shapes;



namespace ContatosDesktop
{
    /// <summary>
    /// Lógica interna para NovaJaneladeContato.xaml
    /// </summary>
    public partial class NovaJaneladeContato : Window
    {
        public string Email { get; private set; }
        public string Phone { get; private set; }

        public NovaJaneladeContato()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            // Salvar o contato
            Contato contato = new Contato();
            {
                Name = nameTextBox.Text;
                Email = emailTextbox.Text;
                Phone = phoneTextbox.Text;
            };
            
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contato>();
                connection.Insert(contato);

            }



            Close();
        }

        private void NewMethod()
        {
            Email = emailTextbox.Text;
        }
    }
}
