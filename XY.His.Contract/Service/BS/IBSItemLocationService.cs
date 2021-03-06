﻿using System;
using System.Collections.Generic;
using System.Text;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Service.BS
{
    public interface IBSItemLocationService : IService<BsItemLocationDto>
    {
        IEnumerable<BsItemLocationDto> GetByItemId(int itemId);
    }
}
