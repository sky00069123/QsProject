namespace HelloWorld {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;

    @EntryPoint()
    operation SayHello() : Unit {
        Message("Hello from quantum world!");
    }
}
