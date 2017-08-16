using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AchadosPerdidos.Infra.Models;

namespace AchadosPerdidos.Teste
{
    [TestClass]
    public class ValidaUsuario
    {
        [TestMethod]
        public void UsuarioValido()
        {
            //arrange:
            string Nome = "Jose";
            string Sobrenome = "Villa";
            DateTime DataNascimento = new DateTime(1999, 1, 10);
            string Telefone = "19997414052";
            string Email = "lorrann.correa@outlook.cm";

            //act:
            var user = new Usuario(Nome, Sobrenome, Telefone, Email, DataNascimento);

            //assert:
            Assert.IsNotNull(user);
            Assert.IsTrue(user.Nome == Nome);
            Assert.IsTrue(user.Sobrenome == Sobrenome);
            Assert.IsTrue(user.DadaNascimento == DataNascimento);
            Assert.IsTrue(user.Telefone == Telefone);
            Assert.IsTrue(user.Email == Email);
        }
    }
}
