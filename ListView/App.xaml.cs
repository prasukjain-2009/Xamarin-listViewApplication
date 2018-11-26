
using ListView.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ListView
{
    public partial class App : Application
    {
        static  PersonDataBase dataBase;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EntryPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        public static PersonDataBase DataBase
        {
            get{
                if (dataBase == null)
                {
                    var path = DependencyService.Get<IFileHelperTwo>().getPath();

                    dataBase = new PersonDataBase(path);
                        //DependencyService.Get<IFileHelper>().GetLocalFilePath("PersonSQLite.db3"));
                       
                }
                return dataBase;
            }

        }
    }
}
