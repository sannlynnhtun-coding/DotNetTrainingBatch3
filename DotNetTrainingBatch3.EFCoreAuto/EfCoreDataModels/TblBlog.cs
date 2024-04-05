using System;
using System.Collections.Generic;

namespace DotNetTrainingBatch3.EFCoreAuto.EfCoreDataModels;

public partial class TblBlog
{
    public int BlogId { get; set; }

    public string BlogTitle { get; set; } = null!;

    public string BlogAuthor { get; set; } = null!;

    public string BlogContent { get; set; } = null!;
}
