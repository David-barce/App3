using System;

namespace App3.ViewModels
{
    public class NombreViewModel : ViewModelBase
    {
        private string nom;
        private string ap1;
        private string ap2;

        public string Nombre
        {
            get => nom;
            set
            {
                if (String.Equals(nom, value)) return;
                nom = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(NomCompleto));
            }

        }

        public string ApPaterno
        {
            get => ap1;
            set
            {
                if (String.Equals(ap1, value)) return;
                ap1 = value;
                RaisePropertyChanged(nameof(ApPaterno));
                RaisePropertyChanged(nameof(NomCompleto));
            }

        }

        public string ApMaterno
        {
            get => ApMaterno;
            set
            {
                if (String.Equals(ap2, value)) return;
                ap2 = value;
                RaisePropertyChanged(nameof(ApMaterno));
                RaisePropertyChanged(nameof(NomCompleto));
            }

        }

        public string NomCompleto
        {
            get => string.Format("Tu nombre es: {0} {1} {2}", nom, ap1, ap2);
        }

    }
}
