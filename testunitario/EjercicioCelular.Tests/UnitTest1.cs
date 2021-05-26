using System;
using System.IO;
using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioCelular;

namespace EjercicioCelular.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Teclas_ShouldReturnNumbers()
        {
            //Arrange
            String texto = "hola mundo";
            String expected = "4466655520688663666";

            //Act
            ProcesarTexto pruebaTexto = new ProcesarTexto();
            String actual = pruebaTexto.teclas(texto);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
