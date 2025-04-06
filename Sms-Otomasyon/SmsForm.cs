using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Sms_Otomasyon
{
    public partial class SmsForm : Form
    {
        public SmsForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                // Twilio bilgileriniz (bunları kendi bilgilerinle doldur)
                const string accountSid = "ACaaffd159c226bb3d01f48e8b042962a7";
                const string apiKeySid = "SK663688821d14b2a7c74614556a8b7615";
                const string apiSecret = "CapU32Ath9NTyrVnvCF6rZMsEYDRpbDK";
                const string fromPhone = "+12705618169"; // Twilio'dan aldığın numara

                Twilio.TwilioClient.Init(apiKeySid, apiSecret, accountSid);

                var message = Twilio.Rest.Api.V2010.Account.MessageResource.Create(
                    to: new Twilio.Types.PhoneNumber(txtNumara.Text),
                    from: new Twilio.Types.PhoneNumber(fromPhone),
                    body: txtMesaj.Text
                );

                lblDurum.Text = "✅ Mesaj gönderildi! SID: " + message.Sid;
            }
            catch (Exception ex)
            {
                lblDurum.Text = "❌ Hata: " + ex.Message;
                Console.WriteLine(ex);
            }

        }
    }
}
