﻿using System;
using DSharpPlus.VoiceNext;
namespace DiscordBot
{
   
    internal class Program
    {
       
        static void Main(string[] args)
        {
            var bot=new Bot();
            bot.RunAsync().GetAwaiter().GetResult();

        }
    }
}
