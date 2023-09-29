using RMC.Core.Interfaces;
using RMC.Core.Validators;

namespace RMC.Web3.CustomWeb3System.Data.Types
{
    public class SignatureHash : IValidatable<object>
    {
        //  Events ----------------------------------------


        //  Properties ------------------------------------
        public string Value { get; set; }
        object IValidatable<object>.Value { get { return Value;} }

        //  Fields ----------------------------------------


        //  Initialization --------------------------------
        public SignatureHash(string value)
        {
            Value = value;
        }
        

        //  Methods ---------------------------------------
        public override string ToString()
        {
            return $"[{this.GetType().Name}(Value = {Value})]";
        }


        //  Event Handlers --------------------------------
    }
    
}