using System;
using System.Collections.Generic;

namespace DotNetTrainingBatch3.EFCoreAuto.EfCoreDataModels;

public partial class TblAtm
{
    public int AtmId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string CardNumber { get; set; } = null!;

    public decimal Balance { get; set; }
}
