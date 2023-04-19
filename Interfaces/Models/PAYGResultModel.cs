using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBrain.Common.Models
{
    public class PAYGResultModel
    {
        public float Result { get; set; }

        public PAYGResultModel(float result) {
            Result = result;
        }
    }
}
