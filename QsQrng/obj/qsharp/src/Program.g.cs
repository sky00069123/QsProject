//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Qrng\",\"Name\":\"SampleQuantumRandomNumberGenerator\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/kench/QsProject/QsQrng/Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Qrng\",\"Name\":\"SampleQuantumRandomNumberGenerator\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/kench/QsProject/QsQrng/Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Qrng\",\"Name\":\"SampleRandomNumberInRange\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/kench/QsProject/QsQrng/Program.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"max\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Qrng\",\"Name\":\"SampleRandomNumberInRange\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/kench/QsProject/QsQrng/Program.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Qrng\",\"Name\":\"SampleRandomNumber\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":25,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/kench/QsProject/QsQrng/Program.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Qrng\",\"Name\":\"SampleRandomNumber\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/kench/QsProject/QsQrng/Program.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
#line hidden
namespace Qrng
{
    [SourceLocation("C:/Users/kench/QsProject/QsQrng/Program.qs", OperationFunctor.Body, 8, 15)]
    public partial class SampleQuantumRandomNumberGenerator : Operation<QVoid, Result>, ICallable
    {
        public SampleQuantumRandomNumberGenerator(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleQuantumRandomNumberGenerator";
        String ICallable.FullName => "Qrng.SampleQuantumRandomNumberGenerator";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<QVoid, Result> Body => (__in__) =>
        {
#line hidden
            {
#line 9 "C:/Users/kench/QsProject/QsQrng/Program.qs"
                var q = Allocate.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 10 "C:/Users/kench/QsProject/QsQrng/Program.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 11 "C:/Users/kench/QsProject/QsQrng/Program.qs"
                    return MicrosoftQuantumMeasurementMResetZ.Apply(q);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release.Apply(q);
                    }
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<SampleQuantumRandomNumberGenerator, QVoid, Result>(QVoid.Instance);
        }
    }

    [SourceLocation("C:/Users/kench/QsProject/QsQrng/Program.qs", OperationFunctor.Body, 15, 27)]
    public partial class SampleRandomNumberInRange : Operation<Int64, Int64>, ICallable
    {
        public SampleRandomNumberInRange(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleRandomNumberInRange";
        String ICallable.FullName => "Qrng.SampleRandomNumberInRange";
        protected ICallable<Int64, Int64> MicrosoftQuantumMathBitSizeI
        {
            get;
            set;
        }

        protected ICallable<QVoid, Result> SampleQuantumRandomNumberGenerator
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, Int64> MicrosoftQuantumConvertResultArrayAsInt
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> self
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in__) =>
        {
            var max = __in__;
#line 16 "C:/Users/kench/QsProject/QsQrng/Program.qs"
            var bits = QArray<Result>.Create(0L);
#line 17 "C:/Users/kench/QsProject/QsQrng/Program.qs"
            foreach (var idxBit in new QRange(1L, MicrosoftQuantumMathBitSizeI.Apply(max)))
#line hidden
            {
#line 18 "C:/Users/kench/QsProject/QsQrng/Program.qs"
                bits = QArray<Result>.Add(bits, new QArray<Result>(SampleQuantumRandomNumberGenerator.Apply(QVoid.Instance)));
            }

#line 20 "C:/Users/kench/QsProject/QsQrng/Program.qs"
            var sample = MicrosoftQuantumConvertResultArrayAsInt.Apply(bits?.Copy());
#line 21 "C:/Users/kench/QsProject/QsQrng/Program.qs"
            return ((sample > max) ? self.Apply<Int64>(max) : sample);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumMathBitSizeI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.BitSizeI));
            this.SampleQuantumRandomNumberGenerator = this.Factory.Get<ICallable<QVoid, Result>>(typeof(SampleQuantumRandomNumberGenerator));
            this.MicrosoftQuantumConvertResultArrayAsInt = this.Factory.Get<ICallable<IQArray<Result>, Int64>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsInt));
            this.self = this;
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 max)
        {
            return __m__.Run<SampleRandomNumberInRange, Int64, Int64>(max);
        }
    }

    [SourceLocation("C:/Users/kench/QsProject/QsQrng/Program.qs", OperationFunctor.Body, 27, -1)]
    public partial class SampleRandomNumber : Operation<QVoid, Int64>, ICallable
    {
        public SampleRandomNumber(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleRandomNumber";
        String ICallable.FullName => "Qrng.SampleRandomNumber";
        public static EntryPointInfo<QVoid, Int64> Info => new EntryPointInfo<QVoid, Int64>(typeof(SampleRandomNumber));
        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> SampleRandomNumberInRange
        {
            get;
            set;
        }

        public override Func<QVoid, Int64> Body => (__in__) =>
        {
#line 28 "C:/Users/kench/QsProject/QsQrng/Program.qs"
            var max = 50L;
#line 29 "C:/Users/kench/QsProject/QsQrng/Program.qs"
            MicrosoftQuantumIntrinsicMessage.Apply(String.Format("Sampling a random number between 0 and {0}: ", max));
#line 30 "C:/Users/kench/QsProject/QsQrng/Program.qs"
            return SampleRandomNumberInRange.Apply(max);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.SampleRandomNumberInRange = this.Factory.Get<ICallable<Int64, Int64>>(typeof(SampleRandomNumberInRange));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<SampleRandomNumber, QVoid, Int64>(QVoid.Instance);
        }
    }
}