using System.Linq.Expressions;
using System.Net;

namespace kquinapantas7.Vistas;

public partial class vAgregar : ContentPage
{
	public vAgregar()
	{
		InitializeComponent();
	}

	private void BtnGuardar_Clicked(object sender, EventArgs e)
	{
		try
		{
			WebClient cliente = new WebClient();
            //WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
			parametros.Add("codigo", txtcodigo.Text);
			parametros.Add("nombre", txtNombre.Text);
			parametros.Add("apellido", txtNApellido.Text);
			parametros.Add("edad", txtEdad.Text);
			cliente.UploadValues("http://192.168.17.22/moviles/pos.php", "POST", parametros);
			Navigation.PushAsync(new Inicio());
		
		}
                catch (Exception ex)
			{
			DisplayAlert("Alerta", ex.Message, "Cerrar");
		}
			}
        
    }

