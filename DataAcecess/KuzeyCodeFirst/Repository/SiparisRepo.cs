using KuzeyCodeFirst.Models;
using System;

namespace KuzeyCodeFirst.Repository
{
    public class SiparisRepo : RepositoryBase<Siparis, int>
    {
        public void SiparisOlustur()
        {
            //transaction ile yapılacak
        }
        
        public void SiparisRaporu(DateTime baslangic,DateTime bitis)
        {

        }
    }

}
