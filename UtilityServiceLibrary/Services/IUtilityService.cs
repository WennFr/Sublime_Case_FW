using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityServiceLibrary.Services
{
    public interface IUtilityService
    {

        string ConvertToLocaleDateTime(DateTime dateInput);
    }
}
