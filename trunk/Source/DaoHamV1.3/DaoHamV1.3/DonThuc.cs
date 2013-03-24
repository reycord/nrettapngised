﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class DonThuc : BieuThuc
    {
        private double x;
        private double heSo;
        private double soMu;
        private BieuThuc daoHam = null;

        // CONSTRUCTORS
        public DonThuc()
        {
            heSo = 1;
            soMu = 1;
        }

        public DonThuc(double _x, double _heSo, double _soMu)
        {
            x = _x;
            heSo = _heSo;
            soMu = _soMu;
        }

        // TÍNH ĐẠO HÀM + GIÁ TRỊ
        public override double TinhGiaTri()
        {
            return (heSo * Math.Pow(x, soMu));
        }

        public override BieuThuc TinhDaoHam()
        {
            if(daoHam==null)
                daoHam = new DonThuc(x, this.heSo * this.soMu, this.soMu - 1);

            return daoHam;
        }

        // BIỂU DIỄN BIỂU THỨC
        public override string ToString()
        {
            return (heSo + "X ^ " + soMu);
        }
    }
}
