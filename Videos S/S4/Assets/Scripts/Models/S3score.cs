using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Models
{
    [Serializable]
    public class S3score
    {
        public long id;
        public string nombreJugador;
        public long score;
        public String fechaRegistro;
    }

    [Serializable]
    public class S3scoreContainer
    {
        public List<S3score> scoreList;
    }
}
