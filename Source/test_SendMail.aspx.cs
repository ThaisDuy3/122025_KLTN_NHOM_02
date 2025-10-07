using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test_SendMail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSendMal_Click(object sender, EventArgs e)
    {
        SendMail("luuvanquyet2612@gmail.com, hoctap782000@gmail.com", "Gửi mail lần đầu");
    }
    private bool SendMail(string email, string message)
    {
        if (email != "")
        {
            //try
            //{
                var fromAddress = "lienhe.master@gmail.com";//  Email Address from where you send the mail 
                var toAddress = email;
                const string fromPassword = "ffdl mata osbo ppf"; //neiabcekdjluofid
                string subject, title;
                title = "Test gửi mail";
                subject = "<!DOCTYPE html><html><head><title></title></head><body ><div>" +
                "<h3 style=\"margin-top:0px; text-align:center; color:#029ada\">" + message + "</h3>" +
                "</div></body></html>";
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                    smtp.Timeout = 20000;
                }
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress(fromAddress, "Hệ thống học tập online");
                mm.Subject = title;
                mm.To.Add(toAddress);
                mm.IsBodyHtml = true;
                mm.Body = subject;
                smtp.Send(mm);
                return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }
        else
            return false;
    }
}