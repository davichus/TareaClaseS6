using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace DNavarreteS6
{
    public partial class Estudiante : ContentPage
    {
        //private const string Url = "http://10.2.4.215/uisrael2023/estudiante.php";
        private const string Url = "http://eyecomers.com/estudiante.php";
     
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<DNavarreteS6.Datos> _post;

        public Estudiante()
        {
            InitializeComponent();
            obtener();
        }

        async void btnGet_Clicked(System.Object sender, System.EventArgs e)
        {
            
        }

        public async void obtener()
        {
            var content = await client.GetStringAsync(Url);
            List<Datos> posts = JsonConvert.DeserializeObject<List<Datos>>(content);
            _post = new ObservableCollection<Datos>(posts);
            MyListView.ItemsSource = _post;
        }

        void btnInserta_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}

