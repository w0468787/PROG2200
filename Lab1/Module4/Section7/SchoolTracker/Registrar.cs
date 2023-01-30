using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    
    interface IGraduate
    {
        void graduate();

    }
    class Registrar
    {
        List<IGraduate> grads = new List<IGraduate>();
        public Registrar(List<IGraduate> grads) {
            this.grads = grads;
        }

        public void GraduateAll() {
            foreach (var grad in grads)
            {
                grad.graduate();
            }
        }
    }
}
