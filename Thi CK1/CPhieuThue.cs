using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi_CK1
{
    public enum KieuLoaiPhong { A, B, C, D }
    class CPhieuThue
    {
        private string m_mapt;
        private DateTime m_ngaybd;
        private DateTime m_ngaykt;
        private string m_tenkh;
        private KieuLoaiPhong m_loaiphong;
        public CPhieuThue()
        {
            m_mapt = "";
            m_ngaybd = DateTime.Now.Date;
            m_ngaybd = DateTime.Now.Date;
            m_tenkh = "";
            m_loaiphong = KieuLoaiPhong.A;
        }
        public CPhieuThue(string mapt, DateTime ngaybd, DateTime ngaykt, string tenkh, KieuLoaiPhong loaiPhong)
        {
            m_mapt = mapt;
            m_ngaybd = ngaybd;
            m_ngaykt = ngaykt;
            m_tenkh = tenkh;
            m_loaiphong = loaiPhong;
        }
        public string MaPT
        {
            get { return m_mapt; }
            set { m_mapt = value; }
        }
        public DateTime NgayBD
        {
            get { return m_ngaybd; }
            set { m_ngaybd = value; }
        }
        public DateTime NgayKT
        {
            get { return m_ngaykt; }
            set { m_ngaykt = value; }
        }
        public string TenKH
        {
            get { return m_tenkh; }
            set { m_tenkh = value; }
        }
        public KieuLoaiPhong LoaiPhong
        {
            get { return m_loaiphong; }
            set { m_loaiphong = value; }
        }
        public int SoNgayThue
        {
            get
            {

                return (m_ngaykt - m_ngaybd).Days + 1;
            }
        }
    }
}
