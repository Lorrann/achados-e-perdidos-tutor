using AchadosPerdidos.Infra.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            DateTime dataPerda = new DateTime(2017, 6, 15);

            //act:
            var obj = new ObjetoPerdido(tipo, marca, cor, dataPerda);

            var tempo = obj.TempoPerdido;

            //assert
            Assert.IsNotNull(obj);
            Assert.IsTrue(obj.Tipo == tipo);
            Assert.IsTrue(obj.Marca == marca);
            Assert.IsTrue(obj.Cor == cor);
        }
    }
}
