﻿using System;
using Xunit;
using XY.His.Contract.Message;
using XY.His.Client;
using XY.His.Contract.Message.IN;

namespace XY.His.Service.UnitTests.IN
{    
    public class INChinRicipExecServiceUnitTest : TestBase
    {
        public INChinRicipExecServiceUnitTest()
        {
            ClassName = "XY.His.Service.IN.INChinRicipExecService";
        }

        [Fact]
        public void GetById_TestMethod()
        {
            int ID = 24519;
            var getByIdRequest = BuildRequest("GetById", new object[] { ID });

            var getByIdResponse = ServiceWrapper.ProcessRequest(getByIdRequest);
            Assert.True(getByIdResponse.Status == ResponseStatus.OK);

            if (getByIdResponse.Result != null)
            {
                InChinRicipExecDto dto = getByIdResponse.Result as InChinRicipExecDto;
                Assert.Equal(ID, dto.ID);
            }
        }       
    }
}
