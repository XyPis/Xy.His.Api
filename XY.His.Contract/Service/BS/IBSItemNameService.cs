﻿using System;
using System.Collections.Generic;
using System.Text;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Service.BS
{
    public interface IBSItemNameService : IService<BsItemNameDto>
    {
        IEnumerable<BsItemNameDto> GetByItemId(int itemId);
    }
}
