using System;
using AulaPOO_PolimorfismoSobrecarga.classes;

namespace AulaPOO_PolimorfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Tsuka");
            fun.Mostrar(3);

            Console.Beep();
        }
    }
}
