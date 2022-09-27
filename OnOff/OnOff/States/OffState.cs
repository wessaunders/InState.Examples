using InState.Abstracts;

namespace OnOff.States
{
    public class OffState : State<string, Triggers>
    {
        public override string Name { get { return "Off"; }}
    }
}