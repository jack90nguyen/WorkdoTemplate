using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class SuggestModel
  {
    [BsonId]
    public string id { get; set; }

    public string name { get; set; }

    public string cycle { get; set; }

    public string department { get; set; }

    public string type { get; set; }

    public bool draft { get; set; }

    public long date { get; set; }

    public string user { get; set; }
  }
}