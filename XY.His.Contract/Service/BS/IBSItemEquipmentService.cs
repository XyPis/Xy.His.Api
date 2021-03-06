﻿using System;
using System.Collections.Generic;
using System.Text;
using XY.His.Contract.Message.BS;

namespace XY.His.Contract.Service.BS
{
    public interface IBSItemEquipmentService : IService<BsItemEquipmentDto>
    {
        IEnumerable<BsItemEquipmentDto> GetByItemId(int itemId);
    }
}
