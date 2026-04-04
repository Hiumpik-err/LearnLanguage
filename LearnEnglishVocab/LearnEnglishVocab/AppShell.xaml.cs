using LearnEnglishVocab.View;

namespace LearnEnglishVocab
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("/registration", typeof(Registration));
            Routing.RegisterRoute("/home", typeof(HomePage));
            Routing.RegisterRoute("/logining", typeof(LoginPage));

        }
    }
}
