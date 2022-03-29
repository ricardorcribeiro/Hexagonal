namespace ProductManager.Domain.Entities.Base
{
    public class EntityBase
    {
        public int Id { get; protected set ; }

        public int SetId(int id)
        {
            if(id == default) throw new ArgumentNullException();   
            return id; 
        }
    }
}