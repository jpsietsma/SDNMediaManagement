using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        string messageText = Console.ReadLine();
        Console.WriteLine();


        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACabd07d8faae2341c34d01752e4fc95c6";
        const string authToken = "f080d65eab4980fc1ae65bf98bf14182";

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: messageText,
            from: new Twilio.Types.PhoneNumber("+16072149921"),
            to: new Twilio.Types.PhoneNumber("+16074318148")
        );

        Console.ReadLine();
    }
}