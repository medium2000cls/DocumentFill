namespace DocumentFill.Model
{
    public class PatternsContainerFactory
    {
        public IPatternsContainer Create()
        {
            return new PatternsContainer();
        }
    }
}