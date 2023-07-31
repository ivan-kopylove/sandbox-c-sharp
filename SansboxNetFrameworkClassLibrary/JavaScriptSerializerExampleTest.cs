using System.Web.Script.Serialization;
using Xunit;

namespace delete
{
    public class JavaScriptSerializerExampleTest
    {
        [Fact]
        public void Deserialize()
        {
            const string Input = @"
                {
                  'myKey': 'myValue'
                }
                ";

            var deserialized = new JavaScriptSerializer().Deserialize<dynamic>(Input);
            Assert.Equal("myValue", deserialized["myKey"]);
        }
    }
}