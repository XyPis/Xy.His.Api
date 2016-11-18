﻿using System;
using System.Collections.Generic;
using System.Text;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Service.BS
{
    public interface IBSItemUnitService : IService<BsItemUnitDto>
    {
        IEnumerable<BsItemUnitDto> GetByItemId(int itemId);
    }
}
