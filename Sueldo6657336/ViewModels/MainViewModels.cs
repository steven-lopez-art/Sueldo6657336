using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Sueldo6657336.ViewModels
{
    public partial class MainViewModels : ObservableObject
    {
        [ObservableProperty]
        public string sueldo;

        [ObservableProperty]
        public string resultado;


        [RelayCommand]
        public void Conversion()
        {
            double sueldo = double.Parse(Sueldo);
            double aumento = sueldo < 1000 ? sueldo * 0.15 : sueldo * 0.12;

            double nuevoSueldo = sueldo + aumento;


            Resultado = $"El nuevo sueldo es: ${nuevoSueldo:F2}";
        }
    }
}
