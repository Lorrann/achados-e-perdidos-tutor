using System;

namespace AchadosPerdidos.Infra.ExtensionMethods
{
    public static class ValidaIdade
    {
        public static int CalculaIdade(this DateTime data)
        {
            var anosDiferenca = DateTime.Now.Year - data.Year;

            if(DateTime.Now.Month < data.Month || (DateTime.Now.Month == data.Month && 
                DateTime.Now.Day < data.Day))
            {
                anosDiferenca--;
            }

            return anosDiferenca;
        }
    }
}
