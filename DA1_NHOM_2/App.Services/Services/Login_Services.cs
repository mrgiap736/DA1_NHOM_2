using App.Data.Entities;
using App.Data.Repos;
using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Microsoft.EntityFrameworkCore.Metadata;
using Org.BouncyCastle.Asn1.Crmf;
using static SendGrid.BaseClient;
using Twilio.Rest;
using System.Net.Http.Headers;
using EllipticCurve.Utils;

namespace App.Services.Services
{
    public class Login_Services
    {
        NhanVien_Repos nvrp;
        public Login_Services()
        {
             nvrp = new NhanVien_Repos();
        }

        public NhanVien GetUS_PW(string username, string password)
        {
            NhanVien nv = null;
            List<NhanVien> _lstnv = nvrp.GetAll();

            for (int i = 0; i < _lstnv.Count; i++)
            {
                if (_lstnv[i].TaiKhoan.Equals(username) && _lstnv[i].MatKhau.Equals(password))
                {
                    nv = _lstnv[i];
                }
            }

            return nv;
        }

        public async void ForgotPass(string toE, string newPass)
        {
            await SendPasswordResetEmail(toE, newPass);
        }


        private async Task<string> SendPasswordResetEmail(string toEmail, string newPassword)
        {

            return "";
        }
    }
}
