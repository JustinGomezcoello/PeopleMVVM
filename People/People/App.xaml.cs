namespace People;

public partial class App : Application
{
    public static PersonRepository PersonRepo { get; private set; }

    public App()
    {
        InitializeComponent();

        // Ruta de la base de datos
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3");

        // Inicializar el repositorio
        PersonRepo = new PersonRepository(dbPath);

        MainPage = new MainPage();
    }
}

