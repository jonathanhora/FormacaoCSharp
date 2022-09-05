using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(5486, 846674);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine(conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro no parâmetro: {ex.ParamName}");
                Console.WriteLine($"ocorreu um erro: {ex.Message}" );
                Console.WriteLine(ex.StackTrace);
            }catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine($"Erro do tipo SaldoInsuficienteException: \n{ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
