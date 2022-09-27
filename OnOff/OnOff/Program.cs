using InState.Abstracts;
using InState.Interfaces;

namespace OnOff
{
    public class Program
    {
        static void Main(string[] args)
        {
            IState<string, Triggers> state;
            
            TwoStateMachine machine = new TwoStateMachine();

            state = machine.Fire(Triggers.On);
            Console.WriteLine(state.Name);
            Console.WriteLine(state.Data.First());

            state = machine.Fire(Triggers.Off);
            Console.WriteLine(state.Name);
            Console.WriteLine(state.Data.First());
        }
    }
}