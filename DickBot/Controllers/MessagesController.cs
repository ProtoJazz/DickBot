using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Connector.Utilities;
using Newtonsoft.Json;

namespace DickBot
{
  
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        /// 
#region DickList
        public static string[] dickArray = new string[] { "Adolph",
       "Albino Cave Dweller",
       "baby-arm",
       "baby-maker",
       "baloney pony",
       "beaver basher",
       "beef whistle",
       "bell on a pole",
       "bishop",
       "Bob Dole",
       "boomstick",
       "braciole",
       "bratwurst",
       "burrito",
       "candle",
       "choad",
       "chopper",
       "chub",
       "chubby",
       "cock",
       "cranny axe",
       "cum gun",
       "custard launcher",
       "dagger",
       "deep-V diver",
       "dick",
       "dickie",
       "ding dong mcdork",
       "dink",
       "dipstick",
       "disco stick",
       "dog head",
       "dong",
       "donger",
       "dork",
       "dragon",
       "drum stick",
       "dude piston",
       "Easy Rider",
       "eggroll",
       "Excalibur",
       "fang",
       "ferret",
       "fire hose",
       "flesh flute",
       "flesh tower",
       "froto",
       "fuck rod",
       "fudge sickle",
       "fun stick",
       "gigi",
       "groin",
       "heat-seeking moisture missile",
       "hog",
       "hose",
       "jackhammer",
       "Jimmy",
       "John",
       "John Thomas",
       "Johnson",
       "joystick",
       "junk",
       "kickstand",
       "king sebastian",
       "knob",
       "krull the warrior king",
       "lap rocket",
       "leaky hose",
       "lingam",
       "little Bob",
       "little Elvis",
       "lizard",
       "longfellow",
       "love muscle",
       "love rod",
       "love stick",
       "luigi",
       "manhood",
       "mayo shooting hotdog gun",
       "meat constrictor",
       "meat injection",
       "meat popsicle",
       "meat stick",
       "meat thermometer",
       "member",
       "meter long king kong dong",
       "microphone",
       "middle stump",
       "Moisture and heat seeking venomous throbbing python of love",
       "Mr. Knish",
       "mushroom head",
       "mutton",
       "netherrod",
       "old boy",
       "old fellow",
       "old man",
       "one-eyed monster",
       "one-eyed snake",
       "one-eyed trouser-snake",
       "one-eyed wonder weasel",
       "one-eyed yogurt slinger",
       "pecker",
       "Pedro",
       "peepee",
       "Percy",
       "peter",
       "Pied Piper",
       "Pig skin bus",
       "pink oboe",
       "piss weasle",
       "piston",
       "plug",
       "pnor",
       "poinswatter",
       "popeye",
       "pork sword",
       "prick",
       "private eye",
       "private part",
       "purple-headed yogurt flinger",
       "purple-helmeted warrior of love",
       "quiver bone",
       "Ramburglar",
       "rod",
       "rod of pleasure",
       "roundhead",
       "sausage",
       "schlong",
       "schlong dongadoodle",
       "schmeckel",
       "schmuck",
       " shmuck",
       "schnitzel",
       "schwanz",
       "schwartz",
       "sebastianic sword",
       "shaft",
       "short arm",
       "single barrelled pump action bollock yogurt shotgun",
       "skin flute",
       "soldier",
       "spawn hammer",
       "steamin’ semen truck",
       "stick shift",
       "surfboard",
       "Tallywhacker",
       "Tan Bannana",
       "tassle",
       "third leg",
       "thumper",
       "thunderbird 3",
       "thundersword",
       "tinker",
       "todger",
       "tonk",
       "tool",
       "trouser snake",
       "tubesteak",
       "twig",
       "twinkie",
       "vein",
       "wand",
       "wang",
       "wang doodle",
       "wanger",
       "wee wee",
       "whoopie stick",
       "wick",
       "wiener",
       "Wiener Schnitzel",
       "willy",
       "wing dang doodle",
       "winkie",
       "yingyang",
       "yogurt gun"};
#endregion

        public async Task<Message> Post([FromBody]Message message)
        {
            if (message.Type == "Message")
            {
                // calculate something for us to return
                foreach (string x in dickArray)
                {
                    if (message.Text.ToLower().Contains(x.ToLower()))
                    {
                        return message.CreateReplyMessage(x + " can mean dick");
                    }
                }

                // return our reply to the user
                return null;
            }
            else
            {
                return HandleSystemMessage(message);
            }
        }

        private Message HandleSystemMessage(Message message)
        {
            if (message.Type == "Ping")
            {
                Message reply = message.CreateReplyMessage();
                reply.Type = "Ping";
                return reply;
            }
            else if (message.Type == "DeleteUserData")
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == "BotAddedToConversation")
            {
            }
            else if (message.Type == "BotRemovedFromConversation")
            {
            }
            else if (message.Type == "UserAddedToConversation")
            {
            }
            else if (message.Type == "UserRemovedFromConversation")
            {
            }
            else if (message.Type == "EndOfConversation")
            {
            }

            return null;
        }
    }
}