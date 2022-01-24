using Microsoft.AspNetCore.Mvc;

namespace WAISM_TestingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringOperationsTestingController : ControllerBase
    {

        private readonly ILogger<StringOperationsTestingController> _logger;

        public StringOperationsTestingController(ILogger<StringOperationsTestingController> logger)
        {
            _logger = logger;
        }

        // GET testing/strings/concatenation?input1=przemek&input2=rodzik&input3=jest&input4=super
        [HttpGet("strings/concatenation", Name = "StringConcatenation")]
        public string StringConcatenation([FromQuery] string input1, string input2, string input3, string input4)
        {
            return input1 + " " + input2 + " " + input3 + " " + input4;
        }

        // GET testing/strings/interpolation?input1=przemek&input2=rodzik&input3=jest&input4=super
        [HttpGet("strings/interpolation", Name = "StringInterpolation")]
        public string StringInterpolation([FromQuery] string input1, string input2, string input3, string input4)
        {
            return $"{input1} {input2} {input3} {input4}";
        }

        // GET testing/strings/concatenation?input1=przemek&input2=rodzik&input3=jest&input4=super
        [HttpGet("strings/substring", Name = "StringSubstring")]
        public string StringSubstring([FromQuery] string sourceString, int startIndex, int endIndex)
        {
            return sourceString[startIndex..++endIndex];
        }

        // GET testing/strings/search?sourceString=string1&pattern=string2
        [HttpGet("strings/existence", Name = "StringExistence")]
        public Boolean StringExistence([FromQuery] string sourceString, string pattern)
         => sourceString.Contains(pattern);

        // GET testing/strings/getValue?sourceString=string1&index=3
        [HttpGet("strings/getValue", Name = "StringGetValueFromIndex")]
        public char StringGetValueFromIndex([FromQuery] string sourceString, int index)
         => sourceString.ElementAt(index);
        
    }
}