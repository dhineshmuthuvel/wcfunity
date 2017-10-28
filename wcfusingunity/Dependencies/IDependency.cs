using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcfusingunity.Dependencies
{
    public interface IDependency
    {
        string GetValue(int value);
    }

    public class Dependency : IDependency
    {
        public string GetValue(int value)
        {
            return "From Dependency " + value.ToString();
        }
    }
}
