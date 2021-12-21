using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi_CK1
{
    class CTruyCapDL
    {
        private static CTruyCapDL m_data = null;
        private List<CPhieuThue> m_pt;
        private CTruyCapDL()
        {
            m_pt = new List<CPhieuThue>();
        }
        public static CTruyCapDL khoitao()
        {
            if (m_data == null)
                m_data = new CTruyCapDL();
            return m_data;
        }
        public List<CPhieuThue> getDSPT()
        {
            return m_pt;
        }
    }
}
