using Exercicio.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        private NavigationPage TextCell;

        public MainPage()
        {
            InitializeComponent();
            listview.ItemsSource = new List<Animal>
            {
                new Animal
                {
                    nome = "Leão",
            tipo = "felino",
            peso = "100kg",
            altura = "2m",
            sexo = "macho",
            caracteristica = "juba grande",
            imagem = "img/leao.jfif"



                },
                  new Animal
                {
                    nome = "Lince",
            tipo = "felino",
            peso = "50kg",
            altura = "1,20m",
            sexo = "macho",
            caracteristica = "Orelhas compridas",
            imagem = "img/lince.jfif"



                },
                    new Animal
                {
                    nome = "Onça",
            tipo = "felino",
            peso = "90kg",
            altura = "1,75m",
            sexo = "macho",
            caracteristica = "manchas em todo corpo",
            imagem = "img/onca.jfif"



                },
                      new Animal
                {
                    nome = "Pantera",
            tipo = "felino",
            peso = "60kg",
            altura = "1,60m",
            sexo = "macho",
            caracteristica = "Cor preta ",
            imagem = "img/pantera.jpg"



                },
                        new Animal
                {
                    nome = "Guepardo",
            tipo = "felino",
            peso = "50kg",
            altura = "1,78m",
            sexo = "macho",
            caracteristica = "Otimo Corredor",
            imagem = "img/guepardo.jfif"



                },
                          new Animal
                {
                    nome = "Tigre",
            tipo = "felino",
            peso = "",
            altura = "",
            sexo = "macho",
            caracteristica = "",
            imagem = "img/tigre.jfif"



                },


            };

            
        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Animal = e.SelectedItem as Animal;
            Detail = new NavigationPage(new ExercicioPage(Animal));
            IsPresented = false;
        }

       
    }
}
