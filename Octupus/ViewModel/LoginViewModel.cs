using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Octupus.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _login;
        private string _password;

        public LoginViewModel()
        {
            LoginCimmand = new Command(ValidLogin);
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public ICommand LoginCimmand { get; private set; }


        public event PropertyChangedEventHandler PropertyChanged;

        private void ValidLogin()
        {
            if (this.Login.Equals("Admin") && Password.Equals("Admin"))
            {
                CancellationToken cancellationTokenSource = new CancellationToken();

                var toast = Toast.Make("Login realizado com sucesso!", CommunityToolkit.Maui.Core.ToastDuration.Short, 15);
                toast.Show(cancellationTokenSource);

                Login = string.Empty;
                Password = string.Empty;
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
