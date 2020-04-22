﻿using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Telnyx.Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting Examples...");

            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build()
            .LoadAppSettingsIntoEnvironmentVariables();

            TelnyxConfiguration.SetApiBase("https://api.telnyx.com/v2");
            TelnyxConfiguration.SetApiKey(config["TelnyxApiKey"]);
            TelnyxConfiguration.SetFilesBase("http://api.telnyx.com/v2");

            Console.WriteLine("MessagesExample...");
            MessagesExample messagesExample = new MessagesExample();
            await messagesExample.SendMessage();
            messagesExample.RetrieveMessage();

            Console.WriteLine("MessagingProfilesExample...");
            MessagingProfilesExample messagingProfilesExample = new MessagingProfilesExample();
            messagingProfilesExample.List();
            messagingProfilesExample.ListAllMessagingProfilePhoneNumbers();
            messagingProfilesExample.Create();
            messagingProfilesExample.Update();
            messagingProfilesExample.Delete();

            Console.WriteLine("NumberOrderExample...");
            NumberOrderExample numberOrderExample = new NumberOrderExample();
            numberOrderExample.ListNumberOrder();
            numberOrderExample.CreateNumberOrder();

            Console.WriteLine("NumberReservationExample...");
            NumberReservationExample numberReservationExample = new NumberReservationExample();
            numberReservationExample.CreateNumberReservation();
            numberReservationExample.ListNumberReservation();

            Console.WriteLine("NumberSearchExample...");
            NumberSearchExample numberSearchExample = new NumberSearchExample();
            numberSearchExample.ListNumberService();

            Console.WriteLine("PhoneNumbersExample...");
            PhoneNumbersExample phoneNumbersExample = new PhoneNumbersExample();
            phoneNumbersExample.GetPhoneNumber();
            phoneNumbersExample.ListNumberOrder();
            phoneNumbersExample.UpdatePhoneNumber();

            Console.WriteLine("CallControlExample...");
            CallControlExample callCommandsExample = new CallControlExample();
            callCommandsExample.Dial();
            callCommandsExample.Speak();
            callCommandsExample.Bridge();
            callCommandsExample.ForkingStart();
            callCommandsExample.ForkingStop();
            callCommandsExample.GatherUsingAudio();
            callCommandsExample.GatherUsingSpeak();
            callCommandsExample.Hangup();
            callCommandsExample.PlaybackStart();
            callCommandsExample.PlaybackStop();
            callCommandsExample.RecordStart();
            callCommandsExample.RecordStop();
            callCommandsExample.Reject();
            callCommandsExample.SendDTMF();
            callCommandsExample.Transfer();
        }
    }
}
