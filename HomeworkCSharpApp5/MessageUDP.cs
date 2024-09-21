using HomeworkCSharpApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HomeworkCSharpApp5
{
    public enum Command
    {
        Register,
        Message,
        Confirmation,
        GetUnreadMessages
    }


    public class MessageUDP
    {
        public Command Command { get; set; }
        public int? Id { get; set; }
        public string FromName { get; set; }
        public string ToName { get; set; }
        public string Text { get; set; }

        public List<string> UnreadMessages { get; set; }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static MessageUDP FromJson(string json)
        {
            return JsonSerializer.Deserialize<MessageUDP>(json);
        }
    }
}
