using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.DIpattern;

namespace MyFIrstSeeSharp.DIpattern
{
    
    class Client
    {
        private IService _service;
        public Client(IService service)
        {
            this._service = service;
        }
        public void Request()
        {
            _service.Serve();
        }
    }
}
