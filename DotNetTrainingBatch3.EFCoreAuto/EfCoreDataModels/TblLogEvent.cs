using System;
using System.Collections.Generic;

namespace DotNetTrainingBatch3.EFCoreAuto.EfCoreDataModels;

public partial class TblLogEvent
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public string? MessageTemplate { get; set; }

    public string? Level { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Exception { get; set; }

    public string? Properties { get; set; }
}
