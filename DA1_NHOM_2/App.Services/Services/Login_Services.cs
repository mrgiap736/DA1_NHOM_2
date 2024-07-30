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
            //74e03cfe6aaec878d2e3db151c313e47-afce6020-ada5533d
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://api.mailgun.net/v3/sandbox653a6654bb8c4a3d89dbfbfff202c625.mailgun.org/messages");
                var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"api:{"74e03cfe6aaec878d2e3db151c313e47-afce6020-ada5533d"}"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("from", "Excited User <mailgun@sandbox653a6654bb8c4a3d89dbfbfff202c625.mailgun.org>"),
                    new KeyValuePair<string, string>("to", toEmail),
                    new KeyValuePair<string, string>("subject", "Your New Password"),
                    new KeyValuePair<string, string>("text", $"Your new password is: {newPassword}")
                });

                var response = await client.PostAsync("", content);

                if (response.IsSuccessStatusCode)
                {
                    return "Gửi mật khẩu mới thành công \n Vui lòng kiểm tra email của bạn";
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return $"Gửi email thất bại: {response.StatusCode}, {responseContent}";
                }
            }

        }
    }
}
