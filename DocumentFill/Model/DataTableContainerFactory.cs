namespace DocumentFill.Model
{
    public class DataTableContainerFactory
    {
        public IDataTableContainer Create()
        {
            return new DataTableContainer();
        }
    }
}