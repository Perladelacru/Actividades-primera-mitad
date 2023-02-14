using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Metodo_cifrado
{
   class Program
   {
       static void Main(string[] args)
       {
        
        // Arreglo que posee la cantidad de caracteres del alfabeto 
        char[] cAlfabeto = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        char[] cMensaje;
    
        Console.Clear();
        Console.WriteLine("Ingrese el mensaje a descifrar: ");
        cMensaje = Console.ReadLine().ToUpper().ToCharArray();

        for(int i = 0; i < cMensaje.Length; i++ )
        {
            char car = cMensaje[i];
            if (car>= 'A' && car<= 'Z')
                car = (char)((car - 'A' + 13)%cAlfabeto.Length + 'A');
            cMensaje[i] = car;
        }
        Console.WriteLine(new string(cMensaje));

        }                      
                 
     } 
}