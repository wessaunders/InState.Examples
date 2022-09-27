using InState.Abstracts;
using OnOff.States;

namespace OnOff
{
    public class TwoStateMachine : InStateMachine<string, Triggers>
    {
        public TwoStateMachine()
        {
            OffState offState = new OffState();
            OnState onState = new OnState();

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