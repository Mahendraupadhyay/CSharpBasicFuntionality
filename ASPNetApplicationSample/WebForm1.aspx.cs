using System;
using System.Net;
using System.Net.Mail;
using ASPNetApplicationSample.WebServiceSample;
namespace ASPNetApplicationSample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebServiceSampleSoapClient soapClient = new WebServiceSampleSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
        #region Code to send mail
        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("adsharma246@gmail.com");
            mailMessage.To.Add("mahendraupadhyay14@gmail.com");
            mailMessage.Subject = "Test Email From Mahendra ASP.Net444";
            mailMessage.Body = "Test Mail";
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("adsharma246@gmail.com", "mahii14up");
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                smtpClient.Send(mailMessage);
                Label1.Text = "Mail sent successfully";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion

        protected void btnInvokeGetMessage_Click(object sender, EventArgs e)
        {
          Label1.Text=  soapClient.Add(Convert.ToInt32(txtNum1.Text),Convert.ToInt32(txtNum2.Text));
        }

        protected void btnInvokeGetNumber_Click(object sender, EventArgs e)
        {
            Label1.Text = soapClient.Substraction(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
        }
    }
}