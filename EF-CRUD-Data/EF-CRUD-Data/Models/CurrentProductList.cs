﻿using System;
using System.Collections.Generic;

namespace EF_CRUD_Data.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
