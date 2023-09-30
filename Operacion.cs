using System;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion numero1;
        private Numeracion numero2;

        public Operacion(Numeracion numero1, Numeracion numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public Numeracion Numero1
        {
            get 
            { 
                return this.numero1; 
            }
            set 
            { 
                this.numero1 = value; 
            }
        }

        public Numeracion Numero2
        {
            get 
            { 
                return this.numero2; 
            }
            set 
            { 
                this.numero2 = value; 
            }
        }

        public void Operar(char operador = '+')
        {
            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = numero1.ValorNumerico + numero2.ValorNumerico;
                    break;
                case '-':
                    resultado = numero1.ValorNumerico - numero2.ValorNumerico;
                    break;
                case '*':
                    resultado = numero1.ValorNumerico * numero2.ValorNumerico;
                    break;
                case '/':
                    // Verificar si el divisor es cero
                    if (numero2.ValorNumerico != 0)
                    {
                        resultado = numero1.ValorNumerico / numero2.ValorNumerico;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operador no válido.");
                    return;
            }

            Console.WriteLine($"Resultado de la operación: {resultado}");
        }
    }
}
