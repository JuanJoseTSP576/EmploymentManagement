    using EmploymentManagement.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    namespace EmploymentManagement.ViewModel
    {
        public class LoginViewModel : ViewModelBase
        { 
            //Campos del formulario
            private string _username;
            private SecureString _password;
            private string _errorMessage;
            private bool _isViewVisible = true;

            //Declaraciones de propiedades
            public string Username
            {
                get
                {
                    return _username;
                }
                set
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }

            public SecureString Password
            {
                get
                {
                    return _password;
                }
                set
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }

            public string ErrorMessage
            {
                get
                {
                    return _errorMessage;
                }
                set
                {
                    _errorMessage = value;
                    OnPropertyChanged(nameof(ErrorMessage));
                }
            }

            public bool IsViewVisible
            {
                get
                {
                    return _isViewVisible;

                }
                set
                {
                    _isViewVisible = value;
                    OnPropertyChanged(nameof(IsViewVisible));
                }
            }


            //->Comandos
            public ICommand LoginCommand { get; }
            public ICommand RecoverPasswordCommand { get; }
            public ICommand ShowPasswordCommand { get; }

            //Constructor
            public LoginViewModel()
            {
                LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
                RecoverPasswordCommand = new ViewModelCommand(p=>ExecuteRecoverPasswordCommand("",""));
          
            }


            private bool CanExecuteLoginCommand(object obj)
            {
                bool validData;
                if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 ||
                    Password == null || Password.Length < 3)
                {
                    validData = false;
                }
                else
                {
                    validData = true;
                }
                return validData;
            }

            private void ExecuteLoginCommand(object obj)
            {
                throw new NotImplementedException();
            }

            private void ExecuteRecoverPasswordCommand(string username, string email)
            {
                throw new NotImplementedException();
            }

        }
    }

