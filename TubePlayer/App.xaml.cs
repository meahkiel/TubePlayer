

using MonkeyCache.FileStore;
using System.Threading;

namespace TubePlayer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Barrel.ApplicationId = "TubePlayerDemo";
            MainPage = new NavigationPage(new StartPage());
        }
    }
}
