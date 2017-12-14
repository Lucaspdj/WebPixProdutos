using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class PropiedadesRep
    {
        public static int Save(Propiedades obj)
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
                    return obj.ID;
                }
                else
                {
                    using (var db = new WebPixContext())
                    {

                        db.Propiedades.Update(obj);
                        db.SaveChanges();
                        return obj.ID;
                    }
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public static bool SaveDept(List<Estrutura> departamento,int idUsuario,int idPropiedade)
        {

            foreach (Estrutura obj in departamento)
            {
                obj.dataCriacao = DateTime.Now;
                obj.dataEdicao = DateTime.Now;
                try
                {
                    if (obj.ID == 0)
                    {

                        var query = String.Format(
                                    @"insert into EstruturaXPropriedade   
                                    values({0}, {1}, '{2}', '{3}', {4}, {5})",
                                    obj.ID,
                                    idPropiedade,
                                    DateTime.Now,
                                    DateTime.Now,
                                    idUsuario,
                                    idUsuario);


                        using (var db = new WebPixContext())
                        {
                            int noOfRowInserted = db.Database.ExecuteSqlCommand(query);
                        }
                        //return true;
                    }
                    else
                    {
                        using (var db = new WebPixContext())
                        {
                            //db.Propiedades.Update(obj);
                            //db.SaveChanges();
                            //return true;
                        }
                    }
                }
                catch (Exception e)
                {
                    //return false;
                }

            }
            return true;


        }
        public static void SaveArquivos(List<Arquivo> arquivosVinculado)
        {
            throw new NotImplementedException();

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
