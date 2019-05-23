namespace YazilimYapimi
{
    public class Update
    {
        public void UpdateData(Tarih tarih)
        {
            using(KelimelerEntities context=new KelimelerEntities())
            {
                var Updated = context.Entry(tarih);
                Updated.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        
    }
}
