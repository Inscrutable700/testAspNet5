using Data;

namespace Business
{
    public class ManagerBase
    {
        protected DataContext DataContext;

        public ManagerBase(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }
    }
}
