using InState.Abstracts;
using OnOff.States;

namespace OnOff
{
    public class TwoStateMachine : InStateMachine<string, Triggers>
    {
        public TwoStateMachine()
        {
            OffState offState = new OffState();
            offState.Data.Add("This state is off");

            OnState onState = new OnState();
            onState.Data.Add("This state is on");

            States.Add(offState);
            States.Add(onState);
            InitialState(offState);

            offState
                .When(Triggers.On)
                    .TransitionTo(onState);

            onState
                .When(Triggers.Off)
                    .TransitionTo(offState);
        }
    }
}