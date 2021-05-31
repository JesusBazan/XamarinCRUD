using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCRUD.Model;

namespace XamarinCRUD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallePage : ContentPage
    {
        public DetallePage(PersonaModel modelo)
        {
            InitializeComponent();
            BindingContext = modelo;
        }
    }
}