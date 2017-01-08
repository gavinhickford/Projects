using SIGN.Controllers.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using SIGN.Domain.Interfaces;

namespace SIGN.Tests
{
    public class Class1
    {
        [Fact]
        public void Test1()
        {
            // ISIGNRepository repository 
            //AppController controller = new AppController()
            Assert.Equal(2, 1 + 1);
        }
    }
}
