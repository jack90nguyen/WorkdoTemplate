using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Workdo.Models
{
  public class TimelineModel
  {
    [BsonId]
    public string id { get; set; }

    public string name { get; set; }

    public string cycle { get; set; }

    public string department { get; set; }

    public string detail { get; set; }

    public string result { get; set; }

    public long start { get; set; }

    public long end { get; set; }

    public int status { get; set; }

    public List<string> members { get; set; }
  }
}