﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class ToBUS
    {
        public static DataTable LoadTo()
        {
            return ToDAO.LoadTo();
        }

        public static bool ThemTo(ToDTO T)
        {
            return ToDAO.ThemTo(T);
        }

        public static bool CapNhatTo(ToDTO T)
        {
            return ToDAO.CapNhatTo(T);
        }

        public static bool XoaTo(int MaTo)
        {
            return ToDAO.XoaTo(MaTo);
        }
    }
}
