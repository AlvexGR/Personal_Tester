using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLibrary.Models
{
    public interface IProblem
    {
        int Id { get; }
    }

    public class ProblemModel : IProblem
    {
        public int Id { get; }
    }
}
