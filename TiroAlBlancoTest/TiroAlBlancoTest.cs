using Microsoft.VisualStudio.TestTools.UnitTesting;
using TiroAlBlancoModel;

namespace TiroAlBlancoTest
{
    [TestClass]
    public class TiroAlBlancoTest
    {
        [TestMethod]
        public void crearMisil()
        {
            IMisil misil = TiroAlBlancoFactory.CrearMisil(0, 0);
            Assert.AreNotEqual(misil, null);
        }
    }
}
