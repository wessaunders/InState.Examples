using InState.Abstracts;

namespace OnOff.States
{
    public class OnState : State<string, Triggers>
    {
        public override string Name { get { return "On"; }}
    }
}