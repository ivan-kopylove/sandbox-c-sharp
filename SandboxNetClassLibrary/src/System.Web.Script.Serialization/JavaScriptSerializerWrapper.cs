using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace sandbox_net_class_library.System.Web.Script.Serialization
{
    public class JavaScriptSerializerWrapper
    {
        public JavaScriptSerializerWrapper()
        {

        }

        public void Deserialize(string input)
        {
            var deserialized = new JavaScriptSerializer().Deserialize<dynamic>(input);
            Console.WriteLine(deserialized.ToString());

        }


    }
}
