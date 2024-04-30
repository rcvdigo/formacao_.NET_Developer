using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModuloMVC.Models
{
    public class Message
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Value { get; set; }
        public string Date { get; set; }
        [JsonProperty("key_pix")]
        public string KeyPix { get; set; }
        public string Source { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        [JsonProperty("phone_numbers")]
        public string PhoneNumber { get; set; }
    }
}