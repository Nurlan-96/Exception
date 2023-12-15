using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice.PracticeException
{
    public class OverthelimitException:Exception
    {
        public OverthelimitException()
        {
            
        }
        public OverthelimitException(string message) : base(message)
        {
        
        }
    }
}
