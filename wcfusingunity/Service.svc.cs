using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using wcfusingunity.Dependencies;

namespace wcfusingunity
{
    
    public class Service : IService
    {
        private readonly IDependency _dependency;

        public Service(IDependency dependency)
        {
            _dependency = dependency;
        }

        public string GetData(int value)
        {
            return _dependency.GetValue(value);
        }
    }
}
