using Craftsmanship.Utils;

namespace Testes
{
    public class Calculo_Testes
    {
        [Fact]
        public void Somar()
        {
            int resultado = Calculo.Somar(5, 5);
            
            //Assert
            Assert.Equal(10, resultado);
        }
    }
}