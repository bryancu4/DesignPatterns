using System.Linq;

namespace BridgePattern
{
    public class BackwardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {new string(value.Reverse().ToArray())}";
        }
    }
}
