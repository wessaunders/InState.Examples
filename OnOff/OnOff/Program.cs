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
            machine.Fire(Triggers.On);

            state = machine.CurrentState;

            Console.WriteLine(state.Name);
        }
    }
}