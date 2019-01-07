using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;

namespace DemirbasOtomasyon.Controller
{
    public static class AtikController
    {
        public static void AtikEkle(int zimmetID)
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_AtikEkle(zimmetID);
                context.SaveChanges();
            }
        }
       
        public static void AtikListele()
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_AtikListeleme();
                context.SaveChanges();
            }
        }
    }
}
