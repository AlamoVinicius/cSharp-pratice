using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Academia
{
    class Collaborator
    {
        public Int32 ID_USER;
        public string NAME_USER;
        public string USERNAME;
        public string PASSWORD;
        public string STATUS;
        public Int32 NIVEL;
        public Collaborator(string NAME_USER, string USERNAME, string PASSWORD, string STATUS, Int32 NIVEL)
        {
            this.NAME_USER = NAME_USER;
            this.USERNAME = USERNAME;
            this.PASSWORD = PASSWORD;
            this.STATUS = STATUS;
            this.NIVEL = NIVEL;
        }
    }
}
