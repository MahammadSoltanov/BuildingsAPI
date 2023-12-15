using System;
using System.Collections.Generic;

namespace BuildingsAPI.Models;

public partial class ErrorTable
{
    public int Id { get; set; }

    public string ErrorMessage { get; set; }
}
