using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.Boolean
{
    /**
     * Manages the Variable Boolean Expreesions
     * */
    class BooleanContext
    {
        private Dictionary<string, bool> variables = new Dictionary<string, bool>();

        public bool GetVariable(string name)
        {
            try{
                return variables[name];
            }
            catch (KeyNotFoundException){
                return false; // default value
            }
        }

        public void SetVariable(string name, bool value)
        {
            variables[name] = value;

            Console.WriteLine("Setting Variable '{0}' with value: {1}", name, value);
        }

    }
}
