using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EscrevendoNoCelular.ConsoleApp;

namespace EscrevendoNoCelular.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveRetornar222()
        {
            Teclado teclado = new Teclado("c");
            Assert.AreEqual("222", teclado.resultado);
        }

        [TestMethod]
        public void DeveRetornarQQrCoisa()
        {
            Teclado teclado = new Teclado("SEMPRE ACESSO O DOJOPUZZLES");
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", teclado.resultado);
        }

        [TestMethod]
        public void DeveRetornar22_222()
        {
            Teclado teclado = new Teclado("BC");
            Assert.AreEqual("22_222", teclado.resultado);
        }

        [TestMethod]
        public void DeveRetornar6665552000688663666()
        {
            Teclado teclado = new Teclado("OlA   MUNDO");
            Assert.AreEqual("66655520_0_0688663666", teclado.resultado);
        }

        [TestMethod]
        public void NaoDeveRetornarPassarDE255Carcteres()
        {
            Teclado teclado = new Teclado("ewrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrtrttreeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwwwrrrrrrrrrrgggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggddddddddccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc");
            Assert.AreEqual("Quantidade de caracteres superior ao limite", teclado.resultado);
        }
    }  
}
