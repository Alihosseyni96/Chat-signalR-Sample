using System;
using System.Collections.Generic;

namespace Chat_signalR.Models;

public partial class Member
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int GroupId { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}
