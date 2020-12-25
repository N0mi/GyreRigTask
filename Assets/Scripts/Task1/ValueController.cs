namespace GyreRigTask.Task1
{
    public class ValueController
    {
        private readonly ValueModel _model;
        private readonly ValueView _view;

        public ValueController(ValueModel model, ValueView view)
        {
            _model = model;
            _view = view;

            Init();
        }

        private void Init()
        {
            _model.onChangeValue += _view.ChangeValue;
            _view.onButtonPress += ButtonAction;
        }

        private void ButtonAction()
        {
            _model.Value += 1;
        }


    }
}

