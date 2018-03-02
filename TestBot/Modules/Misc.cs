using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBot.Modules
{
    public class Misc : ModuleBase<SocketCommandContext>
    {
        [Command("Echo")]
        public async Task Echo([Remainder]string message)
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Echoed Message");
            embed.WithDescription(message);
            embed.WithColor(new Color(0, 255, 0));

            await Context.Channel.SendMessageAsync("", false,embed);
        }

        [Command("txtdwnld")]
        public async Task TextDownload()
        {
            var messages = await this.Context.Channel.GetMessagesAsync(10).Flatten();

            var list = new List<string>();

            foreach(var text in messages)
            {
                list.Add(text.Content);    
            }
            string test = string.Join(",", list.ToArray());
            Console.WriteLine(test);




        }
    }
}
