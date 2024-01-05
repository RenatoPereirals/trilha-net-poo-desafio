using DesafioPOO.Models;

namespace test.Models
{
    public class SmartphoneTests
    {
        [Fact]
        public void Ligar_DeveExibirMensagemCorreta()
        {
            // Arrange
            var nokia = new Nokia("123456", "Nokia 8", "IMEI123", 64);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            var resultado = Record.Exception(() => nokia.Ligar());

            // Assert
            Assert.Null(resultado);
        }

        [Fact]
        public void ReceberLigacao_DeveExibirMensagemCorreta()
        {
            // Arrange
            var nokia = new Nokia("123456", "Nokia 8", "IMEI123", 64);

            // Act
            var resultado = Record.Exception(() => nokia.ReceberLigacao());

            // Assert
            Assert.Null(resultado);
        }

        [Fact]
        public void InstalarAplicativo_Nokia_DeveExibirMensagemCorreta()
        {
            // Arrange
            var nokia = new Nokia("123456", "Nokia 8", "IMEI123", 64);

            // Act
            var resultado = Record.Exception(() => nokia.InstalarAplicativo("Facebook"));

            // Assert
            Assert.Null(resultado);
        }

        [Fact]
        public void InstalarAplicativo_Iphone_DeveExibirMensagemCorreta()
        {
            // Arrange
            var iphone = new Iphone("654321", "iPhone X", "IMEI456", 128);

            // Act
            var resultado = Record.Exception(() => iphone.InstalarAplicativo("Instagram"));

            // Assert
            Assert.Null(resultado);
        }
    }
}
