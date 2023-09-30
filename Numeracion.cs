using System.Drawing;

namespace Entidades
{
    public class Numeracion

    {   // Atributos
        public enum ESistema
        {
            Decimal,
            Binario
        }
        private ESistema sistema;
        private double valorNumerico;

        // Constructor
        public Numeracion(ESistema sistema, double valorNumerico)
            :this(valorNumerico.ToString(), sistema) 
        {
        }
        public Numeracion(ESistema sistema, string valorNumerico)
        {
            
            InicializarValores(valorNumerico, sistema);
        }

        // Propiedad
        public double ValorNumerico
        {
            get
            {
                return valorNumerico;
            }
        }

        // Métodos
        private void InicializarValores(string valor, ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                if (EsBinario(valor))
                {
                    valorNumerico = BinarioDecimal(valor);
                }
                else
                {
                    valorNumerico = double.MinValue;
                }
            }
            else if (sistema == ESistema.Decimal)
            {
                double valorParse;
                if (double.TryParse(valor, out valorParse))
                {
                    valorNumerico = valorParse;
                }
                else
                {
                    valorNumerico = double.MinValue;
                }
            }
            this.sistema = sistema;
        }
        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                if(c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;
        }

        private int BinarioDecimal(string valor)
        {
            if(EsBinario(valor))
            {
                int valorDecimal = 0;
                int longitud = valor.Length;

                for (int i = 0; i < longitud; i++)
                {
                    if(valor[i] == '1')
                    {
                        valorDecimal += (int)Math.Pow(2, longitud - 1 - i);
                    }
                }

                return valorDecimal;
            }
            else
            {
                return 0; // Retornar 0 si no es binario
            }
        }

        public string DecimalBinario(int valor)
        {
            // Utiliza Convert.ToString con formato binario para convertir un número decimal a binario.
            return Convert.ToString(valor, 2);
        }

        public string DecimalBinario(string valor)
        {
            if (double.TryParse(valor, out double numeroDecimal))
            {
                int valorEntero = (int)Math.Abs(numeroDecimal);

                // Utiliza Convert.ToString con formato binario para convertir un número decimal a binario.
                return Convert.ToString(valorEntero, 2);
            }

            return "Número inválido";
        }


        public string ConvertirA(ESistema nuevoSistema)
        {
            if(nuevoSistema == sistema)
            {
                // Si el sistema de destino es el mismo, simplemente retornamos el valor actual como cadena.
                return valorNumerico.ToString();
            }
            else
            {
                if(sistema == ESistema.Binario)
                {
                    // Si el sistema actual es binario, convertimos a decimal primero.
                    int valorDecimal = BinarioDecimal(valorNumerico.ToString());
                    if(nuevoSistema == ESistema.Decimal)
                    {
                        return valorDecimal.ToString();
                    }
                    else
                    {
                        return DecimalBinario(valorDecimal);
                    }
                }
                else
                {
                    // Si el sistema actual es decimal, convertimos a binario primero.
                    int valorEntero = (int)Math.Abs(valorNumerico);
                    if(nuevoSistema == ESistema.Decimal)
                    {
                        return valorEntero.ToString();
                    }
                    else
                    {
                        return DecimalBinario(valorEntero);
                    }
                }
            }
        }

        public Numeracion(double valor, ESistema sistema)
        {
            this.sistema = sistema;

            if(sistema == ESistema.Decimal)
            {
                valorNumerico = valor;
            }
            else if(sistema == ESistema.Binario)
            {
                valorNumerico = double.MinValue; // Asignamos el valor mínimo de un double.
            }
        }


        public Numeracion(string valor, ESistema sistema)
        {
            this.sistema = sistema;

            if(sistema == ESistema.Decimal)
            {
                if(double.TryParse(valor, out double numeroDecimal))
                {
                    valorNumerico = numeroDecimal;
                }
                else
                {
                    valorNumerico = double.MinValue;
                }
            }
            else if(sistema == ESistema.Binario)
            {
                if (EsBinario(valor))
                {
                    valorNumerico = BinarioDecimal(valor);
                }
                else
                {
                    valorNumerico = double.MinValue;
                }
            }
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(ESistema.Decimal, n1.valorNumerico + n2.valorNumerico);
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(ESistema.Decimal, n1.valorNumerico - n2.valorNumerico);
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(ESistema.Decimal, n1.valorNumerico / n2.valorNumerico);
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(ESistema.Decimal, n1.valorNumerico * n2.valorNumerico);
        }

        public static bool operator ==(ESistema sistema, Numeracion n)
        {
            return sistema == n.sistema;
        }

        public static bool operator !=(ESistema sistema, Numeracion n)
        {
            return !(sistema == n.sistema);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            // Manejar el caso en que ambas instancias son null
            if (ReferenceEquals(n1, null) && ReferenceEquals(n2, null))
            {
                return true;
            }

            // Si una instancia es null y la otra no, no son iguales
            if (ReferenceEquals(n1, null) || ReferenceEquals(n2, null))
            {
                return false;
            }

            return n1.sistema == n2.sistema;
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }
    }
        
}

