﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HomewrkChat
{
    internal class Message
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static Message? FromJson(string somemessage)
        {
            return JsonSerializer.Deserialize<Message>(somemessage);
        }

        public Message(string nikname, string text)
        {
            this.Name = nikname;
            this.Text = text;
            this.Time = DateTime.Now;
        }

        public Message() { }

        public override string ToString()
        {
            return $"Получено сообщение от {Name} ({Time.ToShortTimeString()}): \n {Text}";
        }
    }
}

