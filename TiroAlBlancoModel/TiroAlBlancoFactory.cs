namespace TiroAlBlancoModel
{
    public class TiroAlBlancoFactory
    {
        public static IMisil CrearMisil(double Velocidad, double Angulo)
        {
            return new MisilBalistico(Velocidad, Angulo);
        }
    }
}