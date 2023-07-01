﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Book_Portal_API.Models;

public partial class Titleauthor
{
    public string AuId { get; set; } = null!;

    public string TitleId { get; set; } = null!;

    public byte? AuOrd { get; set; }

    public int? Royaltyper { get; set; }

    [JsonIgnore]
    public virtual Author Au { get; set; } = null!;

    [JsonIgnore]
    public virtual Title Title { get; set; } = null!;
}
