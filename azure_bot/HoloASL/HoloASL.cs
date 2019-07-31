using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading.Tasks;

namespace HoloASL
{
    public class HoloASL : IBot
    {
        public async Task OnTurn(ITurnContext context)
        {
            ConversationContext.userMsg = context.Activity.Text;

            if (context.Activity.Type is ActivityTypes.Message)
            {
                if (string.IsNullOrEmpty(ConversationContext.userMsg))
                {
                    await context.SendActivity($" {ConversationContext.userMsg}");
                }
            }
            else
            {
                ConversationContext.userMsg = string.Empty;
                await context.SendActivity($"Welcome!\n Please click to record");
            }

        }
    }
}
