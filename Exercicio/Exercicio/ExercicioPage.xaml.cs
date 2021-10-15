using Exercicio.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExercicioPage : ContentPage
    {
        public ExercicioPage(Object animal)
        {
            if (animal == null)
            {
                throw new ArgumentNullException();
            }
            BindingContext = animal;
            InitializeComponent();
        }
    }
}