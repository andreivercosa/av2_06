using System;
namespace avaliacao06_logarEdelogar
{
    public class Usuario : iLogin
    {
      
        public Usuario()
        {
        }

        public void deslogar()
        {
            Console.WriteLine("Logando....");
        }

        public void logar()
        {
            Console.WriteLine("Deslogando....");
        }
    }
}
