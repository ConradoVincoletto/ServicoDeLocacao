using System.Security.Cryptography.X509Certificates;

namespace ServicoDeLocacao_API.Serviços
{
    public class TaxaDeServicoBrasil : ITaxaDeServiço
    {
        public double Taxa(double montante)
        {
            
            if(montante <= 100.00)
            {
                return montante * 0.2;
            }
            else
            {
                return montante * 0.15;
            }
        }
    }
}
