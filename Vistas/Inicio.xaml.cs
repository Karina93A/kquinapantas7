using kquinapantas7.Modelos;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace kquinapantas7.Vistas;

public partial class Inicio : ContentPage
{
	private const string url = "http://192.168.17.22/moviles/pos.php";
	private readonly HttpClient cliente = new HttpClient();
	private ObservableCollection<Estudiante> estud;

    public Inicio()
	{
		InitializeComponent();
		Obtener();
	}
	public  async void Obtener()

	{
		var content = await cliente.GetStringAsync(url);
		List<Estudiante> mostrarEst=JsonConvert.DeserializeObject<List<Estudiante>>(content);
		estud = new ObservableCollection<Estudiante>(mostrarEst);
		ListasEstudiantes.ItemsSource = estud;

    }
}
