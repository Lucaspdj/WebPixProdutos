using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Linq;

namespace Repository
{
    public class PropiedadesRep
    {
        public static bool Save(Propiedades obj)
        {
            obj.dataCriacao = DateTime.Now;
            obj.dataEdicao = DateTime.Now;
            try
            {
                if (obj.ID == 0)
                {
                    using (var db = new WebPixContext())
                    {
                        db.Propiedades.Add(obj);
                        db.SaveChanges();
                    }
                    return true;
                }
                else
                {
                    using (var db = new WebPixContext())
                    {

                        db.Propiedades.Update(obj);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static List<Propiedades> GetAll()
        {
            try
            {
                using (var db = new WebPixContext())
                {
                    return db.Propiedades.ToList();
                }
            }
            catch (Exception e)
            {
                ////
                return new List<Propiedades>();
            }

        }
        public static bool Remove(Propiedades obj)
        {
            try
            {
                using (var db = new WebPixContext())
                {
                    db.Propiedades.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                ////
                return false;
            }

        }
    }
}
