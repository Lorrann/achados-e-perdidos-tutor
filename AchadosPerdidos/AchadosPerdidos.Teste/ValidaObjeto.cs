using AchadosPerdidos.Infra.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AchadosPerdidos.Teste
{
    [TestClass]
    public class ValidaObjeto
    {
        [TestMethod]
        public void ObjetoValido()
        {
            //arrange:
            var tipo = "Celular";
            var marca = "Lenovo";
            var cor = "Preto";

            //act:
            var obj = new ObjetoModel(tipo, marca, cor);

            //assert
            Assert.IsNotNull(obj);
            Assert.IsTrue(obj.Tipo == tipo);
            Assert.IsTrue(obj.Marca == marca);
            Assert.IsTrue(obj.Cor == cor);
        }
    }
}
