using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD
{
    class QuatDung: Thietbi
    {
        public QuatDung() : base()
        {
            this.gia = 500;
        }
        public QuatDung(string maSP, string tenSP, decimal gia, string noiSX, int slBan): base(maSP, tenSP, gia=500, noiSX, slBan)
        {
            this.gia = gia;
        }
        public override string inChuoi()
        {
            return this.maSP + ", Máy quạt đứng," + this.tenSP +", " + this.noiSX + ", " +this.gia + ", " +this.slBan;
        }
    }
}
