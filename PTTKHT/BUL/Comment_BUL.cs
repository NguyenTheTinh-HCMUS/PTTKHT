using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class Comment_BUL
    {
        public static Comment Them(Comment cm)
        {
            Comment rs = null;
            using(PTTKHTEntities context=new PTTKHTEntities())
            {
                context.Comments.Add(cm);
                if (context.SaveChanges() == 1)
                {
                    rs = cm;
                }
            }
            return rs;
        }
    }
}
