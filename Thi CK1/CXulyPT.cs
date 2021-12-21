using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi_CK1
{
    class CXulyPT
    {
        private List<CPhieuThue> dsPT;
        public CXulyPT()
        {
            dsPT = new List<CPhieuThue>();
        }
        public List<CPhieuThue> GetdsPT()
        {
            return dsPT;
        }
        public CPhieuThue tim(string ma)
        {
            foreach (CPhieuThue a in dsPT)
            {
                if (a.MaPT == ma)
                {
                    return a;
                }

            }
            return null;
        }
        public bool them(CPhieuThue x)
        {
            CPhieuThue t = tim(x.MaPT);
            if (t != null)
                return false;
            dsPT.Add(x);
            return true;
        }
        public bool xoa(string mamh)
        {
            CPhieuThue t = tim(mamh);
            if (t == null)
                return false;
            dsPT.Remove(t);
            return true;
        }
    }
}
