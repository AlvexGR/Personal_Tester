using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLibrary.Models
{
    public interface ITestCase
    {

    }

    public class TestCaseModel : ITestCase
    {
        public int Id { set; get; }
          
        public string Name { set; get; }
    }
}
