using System;
using System.Collections.Generic;

namespace DotNetTrainingBatch3.EFCoreAuto.EfCoreDataModels;

public partial class TblPageStatistic
{
    public int PageStatisticsId { get; set; }

    public int SessionDuration { get; set; }

    public int PageViews { get; set; }

    public int TotalVisits { get; set; }

    public string CreatedDate { get; set; } = null!;
}
