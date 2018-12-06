﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Ambrosia
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class DispatcherGenerator : DispatcherGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Threading.Tasks;" +
                    "\r\nusing Ambrosia;\r\nusing static Ambrosia.StreamCommunicator;\r\nusing LocalAmbrosi" +
                    "aRuntime;\r\n\r\nnamespace ");
            
            #line 14 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.interfaceType.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// This class runs in the process of the object that" +
                    " implements the interface ");
            
            #line 17 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.interfaceType.Name));
            
            #line default
            #line hidden
            this.Write("\r\n    /// and communicates with the local Ambrosia runtime.\r\n    /// It is instan" +
                    "tiated in ImmortalFactory.CreateServer when a bootstrapper registers a container" +
                    "\r\n    /// that supports the interface ");
            
            #line 20 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.interfaceType.Name));
            
            #line default
            #line hidden
            this.Write(".\r\n    /// </summary>\r\n    class ");
            
            #line 22 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(" : Immortal.Dispatcher\r\n    {\r\n        private readonly ");
            
            #line 24 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(interfaceType.Name));
            
            #line default
            #line hidden
            this.Write(" instance;\r\n\t\tprivate readonly ExceptionSerializer exceptionSerializer = new Exce" +
                    "ptionSerializer(new List<Type>());\r\n\r\n        public ");
            
            #line 27 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(@"(Immortal z, ImmortalSerializerBase myImmortalSerializer, string serviceName, int receivePort, int sendPort, bool setupConnections)
            : base(z, myImmortalSerializer, serviceName, receivePort, sendPort, setupConnections)
        {
            this.instance = (");
            
            #line 30 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(interfaceType.Name));
            
            #line default
            #line hidden
            this.Write(") z;\r\n        }\r\n\r\n        public  ");
            
            #line 33 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(@"(Immortal z, ImmortalSerializerBase myImmortalSerializer, string localAmbrosiaRuntime, Type newInterface, Type newImmortalType, int receivePort, int sendPort)
            : base(z, myImmortalSerializer, localAmbrosiaRuntime, newInterface, newImmortalType, receivePort, sendPort)
        {
            this.instance = (");
            
            #line 36 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(interfaceType.Name));
            
            #line default
            #line hidden
            this.Write(@") z;
        }

        public override async Task<bool> DispatchToMethod(int methodId, RpcTypes.RpcType rpcType, string senderOfRPC, long sequenceNumber, byte[] buffer, int cursor)
        {
            switch (methodId)
            {
                case 0:
                    // Entry point
                    this.EntryPoint();
                    break;
");
            
            #line 47 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"

    foreach (var M in this.methods) {
      var idNumber = M.idNumber;
      var parameterString = String.Join(",", M.Parameters.Select(p => "p_" + p.Position.ToString()));
      var voidMethod = M.voidMethod;

            
            #line default
            #line hidden
            this.Write("                case ");
            
            #line 53 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(idNumber));
            
            #line default
            #line hidden
            this.Write(":\r\n                    // ");
            
            #line 54 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write("Async\r\n                    {\r\n                        // deserialize arguments\r\n");
            
            #line 57 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"

        foreach (var p in M.Parameters) {
          var parIndex = p.Position;
          var parName = "p_" + parIndex;

            
            #line default
            #line hidden
            this.Write("\r\n            // arg");
            
            #line 63 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 63 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.TypeName));
            
            #line default
            #line hidden
            this.Write("\r\n            ");
            
            #line 64 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.DeserializeValue(p.ParameterType, parName)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 65 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                        // call the method\r\n");
            
            #line 67 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 if (!voidMethod) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\tvar p_");
            
            #line 68 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Parameters.Count()));
            
            #line default
            #line hidden
            this.Write(" = default(");
            
            #line 68 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.ReturnType.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 69 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\tbyte[] argExBytes = null;\r\n\t\t\t\t\t\tint argExSize = 0;\r\n\t\t\t\t\t\tException currEx" +
                    " = null;\r\n\t\t\t\t\t\tint arg");
            
            #line 73 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Parameters.Count()));
            
            #line default
            #line hidden
            this.Write("Size = 0;\r\n\t\t\t\t\t\tbyte[] arg");
            
            #line 74 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Parameters.Count()));
            
            #line default
            #line hidden
            this.Write("Bytes = null;\r\n\r\n\t\t\t\t\t\ttry \r\n\t\t\t\t\t\t{\r\n");
            
            #line 78 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 if (!voidMethod) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\tp_");
            
            #line 79 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Parameters.Count()));
            
            #line default
            #line hidden
            this.Write(" =\r\n");
            
            #line 80 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t\tawait this.instance.");
            
            #line 81 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 81 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterString));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t\tcatch (Exception ex)\r\n\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\tcurrEx = ex;\r\n\t\t\t\t\t\t}\r\n\r" +
                    "\n                        if (!rpcType.IsFireAndForget())\r\n                      " +
                    "  {\r\n");
            
            #line 90 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 if (!voidMethod) { 
            
            #line default
            #line hidden
            this.Write("                            // serialize result and send it back\r\n\t\t\t\t\t\tif (currE" +
                    "x != null)\r\n\t\t\t\t\t\t{\r\n\t\t\t");
            
            #line 94 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.ComputeExceptionSize()));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t\telse \r\n\t\t\t\t\t\t{\r\n\t\t\t");
            
            #line 98 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.ComputeArgumentSize(M.ReturnType, M.Parameters.Count())));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t}\r\n");
            
            #line 100 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("                            // serialize result and send it back (there isn\'t one" +
                    ")\r\n                            arg");
            
            #line 102 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Parameters.Count()));
            
            #line default
            #line hidden
            this.Write("Size = 0;\r\n");
            
            #line 103 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                            var wp = this.StartRPC_ReturnValue(senderOfRPC, seque" +
                    "nceNumber, currEx == null ? arg");
            
            #line 104 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Parameters.Count()));
            
            #line default
            #line hidden
            this.Write("Size : argExSize, currEx == null ? ");
            
            #line 104 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!voidMethod ? "ReturnValueTypes.ReturnValue" : "ReturnValueTypes.EmptyReturnValue"));
            
            #line default
            #line hidden
            this.Write(" : ReturnValueTypes.Exception);\r\n\r\n");
            
            #line 106 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 if (!voidMethod) { 
            
            #line default
            #line hidden
            this.Write("\t\r\n\t\t\t\t\t\tif (currEx != null)\r\n\t\t\t\t\t\t{\r\n\t\t\t");
            
            #line 109 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.SerializeException()));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t\telse \r\n\t\t\t\t\t\t{\r\n            ");
            
            #line 113 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.SerializeValue(M.Parameters.Count())));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t}\r\n");
            
            #line 115 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                            this.ReleaseBufferAndSend();\r\n                       " +
                    " }\r\n                    }\r\n                    break;\r\n");
            
            #line 120 "C:\Git\Franklin\AmbrosiaCS\DispatcherGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            }\r\n\r\n            return true;\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal class DispatcherGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}