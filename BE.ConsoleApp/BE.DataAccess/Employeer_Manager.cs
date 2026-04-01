using BE.DataAccess.@enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DataAccess
{
    public static class Employeer_Manager
    {
        public static int EmployeerInsert(string Id, string Name, DateTime StartDate)
        {
            var result = 0;
            try
            {
                //Bước 1: Kiểm tra dữ liệu đầu vào
                if (BE.Common.ValidateDataInput.CheckValidateString(Id))
                {
                    result = (int)EmployeerManagerStatus.MA_NHAN_VIEN_KHONG_HOP_LE;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
