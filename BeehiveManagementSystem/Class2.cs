using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Bee
    {
        public string Job {get; private set;}
        public Bee(string job) {
            Job = job;
        }
    }
}
