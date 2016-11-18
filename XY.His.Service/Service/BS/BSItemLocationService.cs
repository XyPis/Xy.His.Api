﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.Transactions;
using System.Linq.Expressions;
using System.Data.Objects.SqlClient;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using log4net;
using XY.His.Contract.Message.BS;
using XY.His.Contract.Service.BS;
using XY.His.Domain.BS;

namespace XY.His.Service.BS
{
    public class BSItemLocationService : AbstractService<BsItemLocation, BsItemLocationDto>, IBSItemLocationService
    {
        public IEnumerable<BsItemLocationDto> GetByItemId(int itemId)
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    var query = uow.Get<BsItemLocation>(x => x.ItemId == itemId);

                    return query.MapTo<BsItemLocationDto>();
                });
            }
        }
    }
}
