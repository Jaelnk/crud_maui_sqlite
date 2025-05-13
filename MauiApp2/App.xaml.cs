namespace MauiApp2
{
    public partial class App : Application
    {
        public static Modelos.PersonRepositorty personRepo{ get; set; }
        public App(Modelos.PersonRepositorty personRepositorty)
        {
            InitializeComponent();
            personRepo = personRepositorty;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.vPrincipal_bd()));
        }
    }
}