using Microsoft.Extensions.Hosting;
using ProjectMomoDoanation.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Helper
{
    public static class Helper
    {
        public static string Base64Encode(this string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(this string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static async void SetStatusProgram(IUnitOfWork unitOfWork)
        {
            var programs = await unitOfWork.ProgramDonation.GetAllAsync();
            foreach (var program in programs)
            {
                var time = program.DateEnd - program.DateStart;
                if (program.DateStart == DateTime.Now)
                    program.Status = StatusProgram.News;
                if(program.DateEnd == DateTime.Now)
                    program.Status = StatusProgram.EndTime;
                if (time.Days > 0)
                    program.Status = StatusProgram.Active;
            }
            unitOfWork.SaveChange();
        }
    }


    public static class StatusProgram
    {
        public const string News = "Mới tạo";
        public const string Active = "Đang quyên góp";
        public const string EndTime = "Kết thúc quyên góp";
        public const string Close = "Đóng quyên góp";
    }
}
