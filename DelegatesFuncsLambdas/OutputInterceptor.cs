using System;
using System.IO;

namespace DelegatesFuncsLambdas
{
    internal class OutputInterceptor:IDisposable
    {
        private readonly TextWriter _textWriter;

        public OutputInterceptor()
        {
            _textWriter = new StringWriter();
            Console.SetOut(_textWriter);
        }

        public string Output
        {
            get { return _textWriter.ToString(); }
        }        
        
        public void Dispose()
        {
            var standardOutput = Console.OpenStandardOutput();
            var standardOutputWriter = new StreamWriter(standardOutput);
            Console.SetOut(standardOutputWriter);
        }
    }
}