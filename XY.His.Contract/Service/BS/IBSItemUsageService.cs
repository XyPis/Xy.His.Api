﻿using System;
using System.Collections.Generic;
using System.Text;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Service.BS
{
    public interface IBSItemUsageService : IService<BsItemUsageDto>
    {
        IEnumerable<BsItemUsageDto> GetByItemId(int itemId);
    }
}
