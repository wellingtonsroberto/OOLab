using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLab
{
   public class Lampada
    {

         private String modelo;
         private int potencia;
         private int voltagem;
         private String localizacao;
         private bool ligado;
    
        public void Instalar(String novaLoc)
         {

             localizacao = novaLoc;
             Console.WriteLine("Instalado em" + localizacao);
              
         }
         public void    Ligar()
        {
             if (!ligado)
             {
                 ligado = true;
                 Console.WriteLine("L:" + localizacao + "ligada.");
             }

        }

    public void Desligar()
    {
        if(ligado)
   
        ligado = false;
       Console.WriteLine("L: {0} desligada.", localizacao);

   }


    }
}
