using Microsoft.UI.Xaml;
using WinRT.BeeDoneVtableClasses;
using BeeDone.Models.Tache
using 
using BeeDone.Models;
using System.Collections.Generic;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeeDone
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    ObservableCollection<Tache> Taches = new ObservableCollection<Tache>();
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAjouterTache(object sender, RoutedEventArgs e)
        {
            Tache n_tache = new Tache(txtNouvelleTache.Text);
            Taches.Add(n_tache);
        }

        //private void btn_validerClick(object sender, RoutedEventArgs e)
        //{
        //    string nom = LeNom.Text;
        //}
    }
}
