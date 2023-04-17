using System;
using System.Collections.Generic;

namespace Chat_signalR.Models;

public partial class Message
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public int MemberId { get; set; }

    public virtual Member Member { get; set; } = null!;
}
