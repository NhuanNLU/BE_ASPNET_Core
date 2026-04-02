using BE.DataAccess.@enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DataAccess
{
    public class Employeer_Manager
    {
        List<BE.DataAccess.Struct.Employeer> empl = new List<Struct.Employeer>();
        public int EmployeerInsert(string Id, string Name, DateTime StartDate)
        {
            var result = 0;
            try
            {
                //Bước 1: Kiểm tra dữ liệu đầu vào
                if (!BE.Common.ValidateDataInput.CheckValidateString(Id) || 
                    !BE.Common.ValidateDataInput.CheckXSSInput(Id))
                {
                    return (int)EmployeerManagerStatus.MA_NHAN_VIEN_KHONG_HOP_LE;
                   
                }
                if (!BE.Common.ValidateDataInput.CheckValidateString(Name) || 
                    !BE.Common.ValidateDataInput.CheckXSSInput(Name))
                {
                    return (int)EmployeerManagerStatus.TEN_KHONG_HOP_LE;
                }
                //Bước 2: Check trùng trong list chua
                var isDup = empl.FindAll(x => x.Id == Id).FirstOrDefault();
                if (isDup.Id != null) return (int)EmployeerManagerStatus.DA_TON_TAI;
                var employeer = new Struct.Employeer()
                {
                    Id = Id,
                    Name = Name,
                    StartDate = StartDate
                };
                empl.Add(employeer);
                result = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }  
    }

}
