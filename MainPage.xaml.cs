namespace Ejercicio1._2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btninformacion_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(apellidos.Text)
                || string.IsNullOrWhiteSpace(edad.Text) || string.IsNullOrWhiteSpace(correo.Text))
            {
                await DisplayAlert("Aviso", "Debe llenar todos los campos", "Ok");
            }
            else
            {
                var estudiante = new Models.Empleado()
                {
                    Nombres = nombre.Text,
                    Apellidos = apellidos.Text,
                    FechaNacimiento = edad.Text,
                    Correo = correo.Text,
                };

                var paginaSegunda = new Views.Info
                {
                    BindingContext = estudiante
                };
                LimpiarCampos();
                await Navigation.PushAsync(paginaSegunda);
            }
        }

        private void LimpiarCampos()
        {
            nombre.Text = "";
            apellidos.Text = "";
            edad.Text = "";
            correo.Text = "";
        }

    }
}