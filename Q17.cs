using CS_CodeQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
        Example of different access modifier:
        Public - same solution
        Private - same class (within class only)
        Protected - same class or derived class (inheritance)
        Internal - same assembly
        Protected Internal - same assembly AND derived class in another assembly
        Private Protected - same assembly AND in same class or derived class
   */

    internal class Q17
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            baseObj.ShowBaseClassFields();

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.ShowDerivedClassFields();

            AnotherClass anotherObj = new AnotherClass();
            anotherObj.ShowAnotherClassFields();

            DifferentAssembly.ExternalClass externalObj = new DifferentAssembly.ExternalClass();
            externalObj.ShowExternalClassFields();

            Console.ReadLine();
        }
    }

    // Base class with different access modifiers
    public class BaseClass
    {
        public int PublicField = 1;
        private int PrivateField = 2;
        protected int ProtectedField = 3;
        internal int InternalField = 4;
        protected internal int ProtectedInternalField = 5;
        private protected int PrivateProtectedField = 6;

        public void ShowBaseClassFields()
        {
            Console.WriteLine($"BaseClass - PublicField: {PublicField}");
            Console.WriteLine($"BaseClass - PrivateField: {PrivateField}");
            Console.WriteLine($"BaseClass - ProtectedField: {ProtectedField}");
            Console.WriteLine($"BaseClass - InternalField: {InternalField}");
            Console.WriteLine($"BaseClass - ProtectedInternalField: {ProtectedInternalField}");
            Console.WriteLine($"BaseClass - PrivateProtectedField: {PrivateProtectedField}");
        }
    }

    // Derived class in the same assembly
    public class DerivedClass : BaseClass
    {
        public void ShowDerivedClassFields()
        {
            Console.WriteLine($"DerivedClass - PublicField: {PublicField}");
            // Console.WriteLine($"DerivedClass - PrivateField: {PrivateField}"); // Not accessible
            Console.WriteLine($"DerivedClass - ProtectedField: {ProtectedField}");
            Console.WriteLine($"DerivedClass - InternalField: {InternalField}");
            Console.WriteLine($"DerivedClass - ProtectedInternalField: {ProtectedInternalField}");
            Console.WriteLine($"DerivedClass - PrivateProtectedField: {PrivateProtectedField}");
        }
    }

    // Another class in the same assembly
    public class AnotherClass
    {
        public void ShowAnotherClassFields()
        {
            // Create a new instance for this class
            BaseClass baseObj = new BaseClass();

            Console.WriteLine($"AnotherClass - PublicField: {baseObj.PublicField}");
            // Console.WriteLine($"AnotherClass - PrivateField: {baseObj.PrivateField}"); // Not accessible
            // Console.WriteLine($"AnotherClass - ProtectedField: {baseObj.ProtectedField}"); // Not accessible
            Console.WriteLine($"AnotherClass - InternalField: {baseObj.InternalField}");
            Console.WriteLine($"AnotherClass - ProtectedInternalField: {baseObj.ProtectedInternalField}");
            // Console.WriteLine($"AnotherClass - PrivateProtectedField: {baseObj.PrivateProtectedField}"); // Not accessible
        }
    }
}


// A class in a different assembly (simulated here by a different namespace)
namespace DifferentAssembly
{
    public class ExternalClass
    {
        public void ShowExternalClassFields()
        {
            CS_CodeQuestion.BaseClass baseObj = new CS_CodeQuestion.BaseClass();
            Console.WriteLine($"ExternalClass - PublicField: {baseObj.PublicField}");
            // Console.WriteLine($"ExternalClass - PrivateField: {baseObj.PrivateField}"); // Not accessible
            // Console.WriteLine($"ExternalClass - ProtectedField: {baseObj.ProtectedField}"); // Not accessible
            // Console.WriteLine($"ExternalClass - InternalField: {baseObj.InternalField}"); // Not accessible
            Console.WriteLine($"ExternalClass - ProtectedInternalField: {baseObj.ProtectedInternalField}");
            // Console.WriteLine($"ExternalClass - PrivateProtectedField: {baseObj.PrivateProtectedField}"); // Not accessible
        }
    }
}