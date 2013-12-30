using System;
using System.Collections.Generic;
using System.Text;
using MevzuatOrg.Business.Entities;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace MevzuatOrg.Data
{
    public class HaberlerDAC
    {
        public List<Haberler> Select()
        {
            List<Haberler> resultsList = null;

            return resultsList;
        }

        public Haberler GetHaber(int Id)
        {
            Haberler result = null;

            MevzuatDBEntities ctx = MevzuatDBEntities.Context;
            
            result = ctx.Haberler.First(c => c.HaberId == Id);

            return result;
        }
    }
}
