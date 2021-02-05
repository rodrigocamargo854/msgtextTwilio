using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace msgtextTwilio {
    class Program {
        static void Main (string[] args) {
            string accountSid = "";
            string authToken = "";
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