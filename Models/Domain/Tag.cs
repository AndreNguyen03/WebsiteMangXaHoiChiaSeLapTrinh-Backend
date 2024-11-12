﻿using System;
using System.Collections.Generic;

namespace SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.Domain;

public partial class Tag
{
    public Guid Id { get; set; }

    public string Tagname { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Posttag> Posttags { get; set; } = new List<Posttag>();
    public virtual ICollection<WatchedTag> WatchedTags { get; set; } = new List<WatchedTag>();
    public virtual ICollection<IgnoredTag> IgnoredTags { get; set; } = new List<IgnoredTag>();
}