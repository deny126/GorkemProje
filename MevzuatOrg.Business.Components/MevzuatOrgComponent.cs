using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MevzuatOrg.Data;
using System.Transactions;
using MevzuatOrg.Business.Entities;

namespace MevzuatOrg.Business.Components
{
    public class MevzuatOrgComponent
    {
        /// <summary>
        /// Submit an Haberler.
        /// </summary>
        /// <param name="Haberler">An Haberler object.</param>
        public Haberler CreateCustomer(Haberler Haberler)
        {
            Console.WriteLine("Submitting... ");

            //using (TransactionScope ts =
            //    new TransactionScope(TransactionScopeOption.Required))
            //{
            try
            {
                Haberler = CreateHaberler(Haberler);
                //ts.Complete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            //}

            Console.WriteLine("New HaberlerID = " + Haberler.HaberId.ToString());

            return Haberler;
        }

        /// <summary>
        /// Submit changes of customer
        /// </summary>
        /// <param name="Haberler">customer for update</param>
        /// <returns>a Haberler object</returns>
        public Haberler UpdateCustomer(Haberler Haberler)
        {
            //using (TransactionScope ts =
            //    new TransactionScope(TransactionScopeOption.Required))
            //{
            try
            {

                Haberler = UpdateHaberler(Haberler);
                //ts.Complete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            //}

            return Haberler;
        }

        /// <summary>
        /// Creates a new Haberler record in the database.
        /// </summary>
        /// <param name="Haberler">An Haberler object.</param>
        private Haberler CreateHaberler(Haberler Haberler)
        {
            // Business logic.

            Console.WriteLine(Haberler.ToString());

            // Persist data.
            HaberlerDAC dac = new HaberlerDAC();
            return dac.Create(Haberler);
        }

        /// <summary>
        /// Updates the Haberler information into the database.
        /// </summary>
        /// <param name="Haberler">An Haberler object.</param>
        private Haberler UpdateHaberler(Haberler Haberler)
        {
            // Business logic.
            Console.WriteLine(Haberler.ToString());

            // Persist data.
            HaberlerDAC dac = new HaberlerDAC();
            dac.Update(Haberler);

            return Haberler;
        }

        /// <summary>
        /// Return a list of Haberler
        /// </summary>
        /// <returns></returns>
        public List<Haberler> ListHaberler()
        {
            // Retrieve data.
            HaberlerDAC dac = new HaberlerDAC();
            return dac.Select();
        }

        /// <summary>
        /// return a list of Haberler by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Haberler> ListHaberlerByName(string name)
        {
            // Retrieve data.
            HaberlerDAC dac = new HaberlerDAC();
            return dac.SelectByName(name);
        }

        /// <summary>
        /// Get a customer by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Haberler getCustomer(int Id)
        {
            HaberlerDAC dac = new HaberlerDAC();
            return dac.getCustomer(Id);
        }

        /// <summary>
        /// get a list of categories 
        /// </summary>
        /// <returns></returns>
        public List<Makaleler> ListMakaleler()
        {
            CategoryDAC category = new CategoryDAC();
            return category.Select();

        }

        /// <summary>
        /// get a category by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category GetCategory(int id)
        {
            CategoryDAC category = new CategoryDAC();
            return category.GetCategory(id);
        }

        /// <summary>
        /// Delete a customer by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public void delCustomer(int Id)
        {
            HaberlerDAC dac = new HaberlerDAC();
            dac.Delete(Id);
        }

        public List<Haberler> SelectByName(string Name)
        {
            HaberlerDAC dac = new HaberlerDAC();
            return dac.SelectByName(Name);
        }

    }
}
