using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace MevzuatOrg.Business.Entities
{
    public partial class Haberler
    {
        public const string EntitySetName = "Haberler";
        
        [Browsable(false)]
        public string HaberAdi
        {
            get
            {
               string res = "";
            //    if (this. != null)
            //    {
            //        res = this;ss
            //    }
            //    else if (this.CategoryReference != null)
            //    {
            //        this.CategoryReference.Load();
            //        if (this.Category != null)
            //        {
            //            res = this.Category.Name;
            //        }
            //    }

                return res;
            }
            //set
            //{
            //    this.CategoryReference.EntityKey =
            //        new EntityKey("CustomersEntities.Category", "CategoryId", value);
            //}
        }

    }
}
