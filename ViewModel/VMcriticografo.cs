using System.ComponentModel;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CriticografoMAUI_JAGS.ViewModel;

public class VMcriticografo : INotifyPropertyChanged
{
    public VMcriticografo()
    {
        Criticar = new Command(criticar);
    }

    private bool _hombre;
    private string _nombre;
    private bool _mujer;
    private bool _alto;
    private bool _feo;
    private bool _listo;
    private bool _extravagante;
    private bool _raro;
    private bool _grande;
    private string _resultado;

    public event PropertyChangedEventHandler? PropertyChanged;
    public string Resultado
    {
        get => _resultado;
        set
        {
            _resultado = value;
            OnPropertyChanged(nameof(Resultado));
        }
    }


    public string Nombre
    {
        get => _nombre;
        set
        {
            _nombre = value;
            OnPropertyChanged(nameof(Nombre));
        }
    }

    public bool Hombre
    {
        get => _hombre;
        set
        {
            _hombre = value;
            OnPropertyChanged(nameof(Hombre));
        }
    }
    public bool Mujer
    {
        get => _mujer;
        set
        {
            _mujer = value;
            OnPropertyChanged(nameof(Mujer));
        }
    }
    public bool Alto
    {
        get => _alto;
        set
        {
            _alto = value;
            OnPropertyChanged(nameof(Alto));
        }
    }

    public bool Feo
    {
        get => _feo;
        set
        {
            _feo = value;
            OnPropertyChanged(nameof(Feo));
        }
    }

    public bool Listo
    {
        get => _listo;
        set
        {
            _listo = value;
            OnPropertyChanged(nameof(Listo));
        }
    }

    public bool Extravagante
    {
        get => _extravagante;
        set
        {
            _extravagante = value;
            OnPropertyChanged(nameof(Extravagante));
        }
    }

    public bool Raro
    {
        get => _raro;
        set
        {
            _raro = value;
            OnPropertyChanged(nameof(Raro));
        }
    }

    public bool Grande
    {
        get => _grande;
        set
        {
            _grande = value;
            OnPropertyChanged(nameof(Grande));
        }
    }

    public void criticar()
    {
        if (!string.IsNullOrEmpty(Nombre) && (Hombre == true || Mujer == true))
        {
            string nombre = Nombre;
            string sexo = "";

            if (Hombre == true)
            {
                sexo = "Hombre";
            }
            else if (Mujer == true)
            {
                sexo = "Mujer";
            }


            string caracteristicas = "No se seleccionaron caracteristicas";

            string agregarCaracteristica(string a, string b)
            {
                if (a == "No se seleccionaron caracteristicas")
                {
                    a = b;
                }
                else
                {
                    a = a + ", " + b;
                }
                return a;
            }

            if (Alto == true)
            {
                caracteristicas = agregarCaracteristica(caracteristicas, "Alto");
            }
            if (Feo == true)
            {
                caracteristicas = agregarCaracteristica(caracteristicas, "Feo");
            }
            if (Listo == true)
            {
                caracteristicas = agregarCaracteristica(caracteristicas, "Listo");
            }
            if (Extravagante == true)
            {
                caracteristicas = agregarCaracteristica(caracteristicas, "Extravagante");
            }
            if (Raro == true)
            {
                caracteristicas = agregarCaracteristica(caracteristicas, "Raro");
            }
            if (Grande == true)
            {
                caracteristicas = agregarCaracteristica(caracteristicas, "Grande");
            }

            string resultado = "Nombre: " + nombre + "\nSexo: " + sexo + "\nCaracteristicas: " + caracteristicas;

             Resultado=($"Resultado: {resultado}");
        }
        else
        {
            Resultado = ($"Resultado: Porfavor llena todos los campos");
        }
    }


    public ICommand Criticar { get; }



    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }




}