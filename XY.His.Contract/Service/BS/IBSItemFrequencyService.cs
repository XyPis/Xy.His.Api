﻿using System;
using System.Collections.Generic;
using System.Text;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Service.BS
{
    public interface IBSItemFrequencyService : IService<BsItemFrequencyDto>
    {
        IEnumerable<BsItemFrequencyDto> GetByItemId(int itemId);
    }
}
