using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MevzuatOrg.Business.Entities;

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

            MevzuatOrgEntities ctx = MevzuatOrgEntities.Context;
            
            result = ctx.Haberler.First(c => c.HaberId == Id);

            return result;
        }
    }
}
