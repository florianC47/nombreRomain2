namespace NombreRomain.Test
{
        public class Test
        {
            [Fact]
            public void Test1()
            {
                const uint chiffre = 1;

                var nombreRomain = nombreRomain2.Convertisseur.Convertir(chiffre);

                Assert.Equal("I", nombreRomain);
            }
        }
    }