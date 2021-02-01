using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace msgtextTwilio {
    class Program {
        static void Main (string[] args) {
            string accountSid = "AC9c14935847bc6e10a1e10e5e1f9c0c77";
            string authToken = "27ddc48029ef810d137ebce637d4a575";
            TwilioClient.Init (accountSid, authToken);
            var to = "+5521967604013";
            var from = "+14076033468";
            var message = MessageResource.Create (
                to: to,
                from: from,
                body: "O produto que você escolheu chegou a faixa de preço desejada");

            Console.WriteLine (message.Sid);
            Console.ReadLine ();

        }
    }
}