using System;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            while (senha != 2002) {
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
                if (senha != 2002) {
                    Console.WriteLine("Senha inválida");
                }
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
